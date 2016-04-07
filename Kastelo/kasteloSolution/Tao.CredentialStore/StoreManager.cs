using System;
using System.Net;

namespace Tao.CredentialStore
{
    /// <summary>
    /// Adds networking features to the ApplicationStore object.
    /// </summary>
    [Serializable]
    public class StoreManager : ApplicationStore
    {
        // Todo: When Application first runs, create a NEW Initialisation vector and store it somewhere secure!
        [NonSerialized]
        private readonly byte[] _iv = {187, 201, 13, 144, 55, 116, 79, 18, 45, 10, 121, 44, 3, 124, 152, 164};
        
        public StoreManager(string name) : base(name)
        {
            
        }

        public StoreManager(ApplicationStore newStore) : base(newStore)
        {

        }

        public bool UploadToFtp(Uri serverUri, string username, string password)
        {            
            // Create communication (FTP) object
            var request = (FtpWebRequest)WebRequest.Create(serverUri);
            request.Method = WebRequestMethods.Ftp.UploadFile;
            if (username == null) username = "anonymous";
            request.Credentials = new NetworkCredential(username, password);
            request.UseBinary = true;

            // Encrypt the current object (this) to a byte Array
            var encryptedBytes = EncryptObjectToBytes(this, _iv);

            // Write the encrypted files to the ftp server
            var requestStream = request.GetRequestStream();
            requestStream.Write(encryptedBytes,0,encryptedBytes.Length);
            requestStream.Close();

            var response = (FtpWebResponse)request.GetResponse();
            response.Close();
            return true;
        }

        public bool DownloadFromFtp(Uri serverUri, string username, string password)
        {
            // The serverUri parameter should start with the ftp:// scheme. 
            if (serverUri.Scheme != Uri.UriSchemeFtp) return false;
            
            // Get the object used to communicate with the server.
            // Todo: Perhaps needs anonymous options?
            var request = new WebClient {Credentials = new NetworkCredential(username, password)};
            
            try
            {
                byte[] newFileData = request.DownloadData(serverUri.ToString());
                // Decrypt the byte array
                var unencryptedBytes = DecryptObjectFromBytes(newFileData, _iv);
                // Store values from FTP locally.
                Name = unencryptedBytes.Name;
                Applications = unencryptedBytes.Applications;
                
            }
            catch (WebException e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }

            return true;
        }
    }
}
