using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;

namespace Tao.CredentialStore
{
    [Serializable]
    public class ApplicationStore : PasswordGenerator, IItemStore
    {
        // Todo: store this key more securely.
        [NonSerialized]
        protected static readonly byte[] Key = { 17, 21, 3, 14, 155, 216, 19, 118, 145, 100, 122, 165, 12, 199, 204, 32,
                                                    127, 121, 168, 19, 234, 21, 9, 18, 125, 111, 2, 193, 67, 29, 57, 248 };
        public string Name { get; set; }
        public string Notes { get; set; }
        public byte[] Hash { get; set; }
        public List<App> Applications { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime Created { get; set; }

        public ApplicationStore(string name)
        {
            Name = name;
            Applications = new List<App>(0);
            Created = LastUpdated = DateTime.Now;
        }

        public ApplicationStore(ApplicationStore store)
        {
            Name = store.Name;
            Notes = store.Notes;
            Applications = store.Applications;
            Hash = store.Hash;
            Created = store.Created;
            LastUpdated = store.LastUpdated;
        }

        public virtual bool Add(IStoreableItem item)
        {
            if (item.GetType() != typeof (App)) return false;
            var newItem = item as App;
            if (Applications.Exists(x => newItem != null && x.Name == newItem.Name))
                return false;
            Applications.Add(newItem);
            return true;
        }

        public bool Remove(IStoreableItem item)
        {
            return Applications.Remove(item as App);
        }

        public int Count()
        {
            return Applications.Count;
        }

        public static byte[] EncryptObjectToBytes(ApplicationStore sourceObject, byte[] iv)
        {
            byte[] encrypted;
            using (var algorithm = Aes.Create())
            {
                // ReSharper disable once PossibleNullReferenceException
                algorithm.Key = Key;
                algorithm.IV = iv;

                // Create a encryptor to perform the stream transform.
                ICryptoTransform encryptor = algorithm.CreateEncryptor(algorithm.Key, algorithm.IV);

                // Create the streams used for encryption.
                using (var msEncrypt = new MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        var swEncrypt = new BinaryFormatter();
                        //Write all data to the stream.
                        swEncrypt.Serialize(csEncrypt, sourceObject);
                        csEncrypt.FlushFinalBlock();
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }

        public static ApplicationStore DecryptObjectFromBytes(byte[] cipherText, byte[] iv)
        {
            // Declare the string used to hold the decrypted text.
            ApplicationStore plainobject;

            // Create an Rijndael object
            // with the specified key and IV.
            using (var algorithm = Aes.Create())
            {
                // ReSharper disable once PossibleNullReferenceException
                algorithm.Key = Key;
                algorithm.IV = iv;

                // Create a decrytor to perform the stream transform.
                var decryptor = algorithm.CreateDecryptor(algorithm.Key, algorithm.IV);

                // Create the streams used for decryption.
                using (var msDecrypt = new MemoryStream(cipherText))
                {
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (var srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            var binaryFormatter = new BinaryFormatter();
                            try
                            {
                                plainobject = (ApplicationStore)binaryFormatter.Deserialize(srDecrypt.BaseStream);
                            }
                            // ReSharper disable once RedundantCatchClause
                            catch (SerializationException)
                            {
                                throw;
                            }
                        }
                    }
                }

            }

            return plainobject;

        }

        public bool Save(string filePath, byte[] iv)
        {
            // Encrypt this object
            var encryptedBytes = EncryptObjectToBytes(this, iv);

            // Write these encrypted bytes to a file.
            using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                stream.Write(encryptedBytes.ToArray(),0,encryptedBytes.Length);
                return true;
            }
        }

        public bool Load(string filePath, byte[] iv, byte[] hashBytes)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException();

            // Create a byte array from the file contents.
            byte[] encryptedBytes = File.ReadAllBytes(filePath);
            var decryptedApplicationStore = DecryptObjectFromBytes(encryptedBytes, iv);
            

            // check password!
            if (String.CompareOrdinal(Encoding.ASCII.GetString(hashBytes),
                Encoding.ASCII.GetString(decryptedApplicationStore.Hash)) != 0)
                return false;

            // update this object with the values from the decrypted object.
            Name = decryptedApplicationStore.Name;
            Notes = decryptedApplicationStore.Notes;
            Applications = decryptedApplicationStore.Applications;
            Hash = decryptedApplicationStore.Hash;
            return true;
        }
    } 
}