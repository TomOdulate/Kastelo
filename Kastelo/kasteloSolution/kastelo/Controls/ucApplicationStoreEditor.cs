using System;
using System.Windows.Forms;
using Tao.CredentialStore;

namespace Kastelo.Controls
{
    public partial class UcApplicationStoreEditor : UserControl
    {
        public ApplicationStore AppStore { get; private set; }
        public bool HasChanges { get; set; }
        public string Breadcrumb
        {
            set { label1.Text = value; }
        }

        public UcApplicationStoreEditor(ApplicationStore appStore, string breadcrumb)
        {
            InitializeComponent();
            txtUsername.Text = appStore.Name;
            txtNotes.Text = appStore.Notes;
            txtCreatedDate.Text = appStore.Created.ToShortDateString();
            txtLastUpdatedDate.Text = appStore.LastUpdated.ToShortDateString();
            AppStore = appStore;
            Breadcrumb = breadcrumb;
        }

        private void DataChanged(object sender, EventArgs e)
        {
            if (AppStore == null) return;
            AppStore.Name = txtUsername.Text;
            AppStore.Notes = txtNotes.Text;
            AppStore.LastUpdated = DateTime.Now;
            HasChanges = true;
        }
    }
}
