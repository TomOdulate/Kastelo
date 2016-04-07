using System.Drawing;
using System.Windows.Forms;
using Tao.CredentialStore;

namespace Kastelo
{
    class KasteloTreeNode : TreeNode
    {
        private object _tag;
        public bool Haschanged { get; set; }

        public new object Tag
        {
            get { return _tag; }
            set
            {
                if (_tag == value) return;
                _tag = value;
                UpdateValues();
                Haschanged = true;
            }
        }

        public void UpdateValues()
        {
            switch (_tag.GetType().ToString())
            {
                case "Tao.CredentialStore.StoreManager":
                case "Tao.CredentialStore.ApplicationStore":
                    var store = _tag as ApplicationStore;
                    if (store == null) return;
                    Text = Name = store.Name;
                    Tag = store;
                    Haschanged = true;
                    break;
                case "Tao.CredentialStore.App":
                    var app = _tag as App;
                    if (app == null) return;
                    Text = Name = app.Name;
                    Tag = app;
                    Haschanged = true;
                    break;
                case "Tao.CredentialStore.Credential":
                    var cred = _tag as Credential;
                    if (cred == null) return;
                    Text = Name = cred.Username;
                    Tag = cred;
                    Haschanged = true;
                    break;
            }
        }

        public KasteloTreeNode(object kasteloItem)
        {
            if (kasteloItem == null) return;
            var headingFont = new Font("Arial", 10, FontStyle.Bold);
            switch (kasteloItem.GetType().ToString())
            {
                case "Tao.CredentialStore.StoreManager":
                case "Tao.CredentialStore.ApplicationStore":
                    var store = kasteloItem as ApplicationStore;
                    if (store == null) return;
                    Text = Name = store.Name;
                    Tag = store;
                    foreach (App a in store.Applications)
                    {
                        Nodes.Add(new KasteloTreeNode(a) {NodeFont = headingFont});
                    }
                    break;
                case "Tao.CredentialStore.App":
                    var app = kasteloItem as App;
                    if (app == null) return;
                    Text = Name = app.Name;
                    Tag = app;
                    foreach (Credential credential in app.Credentials)
                    {
                        Nodes.Add(new KasteloTreeNode(credential));
                    }
                    break;
                case "Tao.CredentialStore.Credential":
                    var cred= kasteloItem as Credential;
                    if (cred == null) return;
                    Text = Name = cred.Username;
                    Tag = cred;
                    break;
                default:
                    return;
            }
            Haschanged = false;
        }
    }
}
