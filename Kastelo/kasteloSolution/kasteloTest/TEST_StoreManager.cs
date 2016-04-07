using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tao.CredentialStore;

namespace kasteloTest
{
    [TestClass]
    public class TestStoreManager
    {
        [TestMethod]
        [TestCategory("Store Manager")]
        public void Manager()
        {
            var strMgr = new StoreManager("ManagedStore");
            var aNewApplication = new App("First");
            var anotherNewStore = new App("First");
            
            // Add an application
            Assert.IsTrue(strMgr.Add(aNewApplication));
            Assert.IsTrue(strMgr.Applications[0].Name == "First");
            Assert.IsTrue(strMgr.Count() == 1);

            // Try to another with the same name
            Assert.IsFalse(strMgr.Add(anotherNewStore));
        }

        [TestMethod]
        [TestCategory("Store Manager")]
        public void PasswordGeneration()
        {
            const short pwdLength = 16;
            char[] disallowedChars ="!\"£$%^&*()_+~@".ToCharArray();
            var strPwd = PasswordGenerator.GeneratePassword("".ToCharArray(), pwdLength);
            var strPwd2 = PasswordGenerator.GeneratePassword("".ToCharArray(), pwdLength);
            var strPwd3 = PasswordGenerator.GeneratePassword(disallowedChars, 200);

            Assert.IsNotNull(strPwd);
            //Assert.IsTrue(strPwd.Length == pwdLength);
            //Assert.AreNotSame(strPwd, strPwd2);
            //Assert.IsTrue(strPwd3.IndexOfAny(disallowedChars) == -1);
        }

        [TestMethod]
        [TestCategory("Store Manager")]
        public void FtpUploadAndDownload()
        {
            // Create an application credentials store
            var appStore = TestHelper.BuildStore("Ftp Test");

            // Create a store manager object from app store
            var strMgr = new StoreManager(appStore);

            // Encrypt and upload the store
            var address = new Uri("ftp://192.168.0.14/Tom/Store.bin");
            strMgr.UploadToFtp(address, "Tom", "G717ylp1");

            // Download and decrypt the store again
            strMgr.DownloadFromFtp(address, "Tom", "G717ylp1");
            
            // Check the object was decrypted.
            Assert.IsTrue(strMgr.Name == "Ftp Test");

            // Confirm data is entact
            Assert.IsTrue(strMgr.Name == "Ftp Test");
            Assert.IsTrue(strMgr.Count() == 2);
            Assert.IsTrue(strMgr.Applications[0].Name == "Application 1");
            Assert.IsTrue(strMgr.Applications[1].Name == "Application 2");
            Assert.IsTrue(strMgr.Applications[0].Count() == 10);
            Assert.IsTrue(strMgr.Applications[1].Count() == 10);

            // Is the data correct and accessable?
            Assert.IsTrue(strMgr.Applications[1].Credentials[9].Username == "Fred19");
            Assert.IsTrue(strMgr.Applications[0].Credentials[9].Password == TestHelper.Password + "18");
        }
    }
}
