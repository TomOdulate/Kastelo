using System;
using System.Windows.Forms;
using Tao.CredentialStore;

namespace Kastelo.Controls
{
    public partial class UcAppEditor : UserControl
    {
        public App App { get; private set; }
        public bool HasChanges { get; set; }
        public string Breadcrumb
        {
            set { label1.Text = value; }
        }

        public UcAppEditor(App app, string breadcrumb)
        {
            InitializeComponent();
            txtUsername.Text = app.Name;
            txtNotes.Text = app.Notes;
            txtCreatedDate.Text = app.Created.ToShortDateString();
            txtLastUpdatedDate.Text = app.LastUpdated.ToShortDateString();
            App = app;
            Breadcrumb = breadcrumb;
        }

        private void DataChanged(object sender, EventArgs e)
        {
            if (App == null) return;
            //Tag = true;
            App.Name = txtUsername.Text;
            App.Notes = txtNotes.Text;
            App.LastUpdated = DateTime.Now;
            HasChanges = true;
        }
    }
}
