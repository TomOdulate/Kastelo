using System;
using System.Windows.Forms;
using Tao.CredentialStore;

namespace Kastelo.Controls
{
    public partial class UcCredentialEditor : UserControl
    {
        public Credential Credential { get; private set; }
        public bool HasChanges { get; set; }
        public string Breadcrumb
        {
            set { label1.Text = value; }
        }

        public UcCredentialEditor( Credential credential, string breadcrumb)
        {
            InitializeComponent();
            txtUsername.Text = credential.Username;
            txtPassword.Text = credential.Password;
            txtCreatedDate.Text = credential.Created.ToShortDateString();
            txtLastUpdatedDate.Text = credential.LastUpdated.ToShortDateString();
            Credential = credential;
            Breadcrumb = breadcrumb;
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            var u = new UcPasswordGenerator();
            Controls.Add(u);
            u.BringToFront();
            u.Show();
        }

        private void chkShowPasswordCharacters_CheckedChanged(object sender, EventArgs e)
        {
            var obj = sender as CheckBox;
            if (obj == null) return;
            txtPassword.PasswordChar = obj.Checked ? '\0' : '*';
            txtPassword.Refresh();
        }

        private void DataChanged(object sender, EventArgs e)
        {
            if (Credential == null) return;
            //Tag = true;
            Credential.Username = txtUsername.Text;
            Credential.Password = txtPassword.Text;
            Credential.LastUpdated = DateTime.Now;
            HasChanges = true;
        }

        private void btnCopyUsernameToClipboard_Click(object sender, EventArgs e)
        {
            CopyToClipBoard(txtUsername.Text);
        }

        private void btnCopyPasswordToClipboard_Click(object sender, EventArgs e)
        {
            CopyToClipBoard(txtPassword.Text);
        }

        private static void CopyToClipBoard(string value)
        {
            Clipboard.SetText(value);
        }
    }
}
