using System;

namespace Tao.CredentialStore
{
    [Serializable]
    public class Credential : IStoreableItem
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastUpdated { get; set; }

        public Credential(Credential credential)
        {
            Username = credential.Username;
            Password = credential.Password;
            Created = LastUpdated = DateTime.Now;
        }
        
        public Credential(string username, string password)
        {
            Created = DateTime.Now;
            Username = username;
            Password = password;
        }
    }
}
