using Tao.CredentialStore;

namespace kasteloTest
{
    public class TestHelper
    {
        public const string Username = "Fred";
        public const string Password = "Fred'sPassword";
        public static byte[] Iv = { 187, 201, 13, 144, 55, 116, 79, 18, 45, 10, 121, 44, 3, 124, 152, 164 };

        public static ApplicationStore BuildStore(string name)
        {
            // create a two new applications
            var app1 = new App("Application 1");
            var app2 = new App("Application 2");

            // create a store
            var store = new ApplicationStore(name);

            // Now create some credentials for the applicaitons
            for (var i = 0; i < 20; i++)
            {
                var c = new Credential(Username + i, Password + i);
                if (i % 2 == 0)
                    app1.Add(c);                                                   // Add to an application
                else
                    app2.Add(c);
            }

            // add applications to the store.
            store.Add(app1);
            store.Add(app2);

            return store;
        }
        
    }
}
