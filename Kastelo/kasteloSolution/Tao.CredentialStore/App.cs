using System;
using System.Collections.Generic;

namespace Tao.CredentialStore
{
    [Serializable]
    public class App : IItemStore, IStoreableItem
    {
        public string Name { get; set; }
        public string Notes { get; set; }
        public List<Credential> Credentials { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastUpdated { get; set; }

        public App(string name)
        {
            Name = name;
            Credentials = new List<Credential>(0);
            Created = LastUpdated = DateTime.Now;
        }


        public bool Add(IStoreableItem item)
        {
            Credentials.Add(item as Credential);
            return true;
        }

        public bool Remove(IStoreableItem item)
        {
            return Credentials.Remove(item as Credential);
        }

        public int Count()
        {
            return Credentials.Count;
        }
    }
}
