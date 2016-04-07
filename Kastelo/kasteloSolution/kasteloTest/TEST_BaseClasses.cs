using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tao.CredentialStore;

namespace kasteloTest
{
    [TestClass]
    public class TestBaseClasses
    {
        [TestMethod]
        [TestCategory("Base classes")]
        public void ClassStructure()
        {
            // create a store
            var store = TestHelper.BuildStore("Test Store");
            
            // Create a StoreManager object from existing store object
            var strMgr = new StoreManager(store);

            
            // Check data integrity.
            // Were both applications created?
            Assert.IsTrue(store.Count() == 2);

            // were the names of eacj application stored on creation?
            Assert.IsTrue(strMgr.Applications[0].Name == "Application 1");
            Assert.IsTrue(strMgr.Applications[1].Name == "Application 2");

            // Are all the credentials loaded in each application?
            Assert.IsTrue(strMgr.Applications[0].Count() == 10);
            Assert.IsTrue(strMgr.Applications[1].Count() == 10);

            // Is the data correct and accessable?
            Assert.IsTrue(strMgr.Applications[1].Credentials[9].Username == TestHelper.Username + "19");
            Assert.IsTrue(strMgr.Applications[0].Credentials[9].Password == TestHelper.Password + "18");
        }
        
        [TestMethod]
        [TestCategory("Base classes")]
        public void a_EncryptAndDecryptApplicationObject()
        {
            // Create a store
            var store = TestHelper.BuildStore("Test Name");

            // Convert to store manager object
            var strMgr = new StoreManager(store);

            // Encrypt the object into an array of bytes
            var encryptedBytes = ApplicationStore.EncryptObjectToBytes(strMgr, TestHelper.Iv);

            // Decrypt again
            var decryptedStore = ApplicationStore.DecryptObjectFromBytes(encryptedBytes, TestHelper.Iv);
            
            // Check data integrity.
            // Were both applications created?
            Assert.IsTrue(store.Count() == 2);

            // were the names of eacj application stored on creation?
            Assert.IsTrue(decryptedStore.Applications[0].Name == "Application 1");
            Assert.IsTrue(decryptedStore.Applications[1].Name == "Application 2");

            // Are all the credentials loaded in each application?
            Assert.IsTrue(decryptedStore.Applications[0].Count() == 10);
            Assert.IsTrue(decryptedStore.Applications[1].Count() == 10);

            // Is the data correct and accessable?
            Assert.IsTrue(decryptedStore.Applications[1].Credentials[9].Username == TestHelper.Username + "19");
            Assert.IsTrue(decryptedStore.Applications[0].Credentials[9].Password == TestHelper.Password + "18");
        }

        [TestMethod]
        [TestCategory("Base classes")]
        public void a_SaveAndLoadFromFile()
        {
            // Create a store
            var store = TestHelper.BuildStore("Test Name");

            // Save the entire store to disc.
            store.Save("Store.bin", TestHelper.Iv);

            // Does the file exist?
            Assert.IsTrue(File.Exists("Store.bin"));

            // Load the object from the file
            store.Load("Store.bin", TestHelper.Iv, Encoding.ASCII.GetBytes("password"));

            // Confirm data is entact
            Assert.IsTrue(store.Name == "Test Name");
            Assert.IsTrue(store.Count() == 2);
            Assert.IsTrue(store.Applications[0].Name == "Application 1");
            Assert.IsTrue(store.Applications[1].Name == "Application 2");
            Assert.IsTrue(store.Applications[0].Count() == 10);
            Assert.IsTrue(store.Applications[1].Count() == 10);

            // Is the data correct and accessable?
            Assert.IsTrue(store.Applications[1].Credentials[9].Username == "Fred19");
            Assert.IsTrue(store.Applications[0].Credentials[9].Password == TestHelper.Password + "18");
        }
    }
}
