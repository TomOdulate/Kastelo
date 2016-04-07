using System;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Kastelo;
using Kastelo.Controls;
using Kastelo.Properties;
using Tao.CredentialStore;

namespace Kastelo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                Text = Text +
                    String.Format(" ver {0}", ApplicationDeployment.CurrentDeployment.CurrentVersion);
            }
        }

        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        private void ShowEditorControl(ApplicationStore appStore, string breadcrumb)
        {
            if (appStore == null) return;
            for (var i = 0; i < pnlEditor.Controls.Count; i++)
                pnlEditor.Controls.RemoveAt(i);
            var uc = new UcApplicationStoreEditor(appStore, breadcrumb);
            pnlEditor.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.Breadcrumb = breadcrumb;
            uc.Show();
        }

        private void ShowEditorControl(App app, string breadcrumb)
        {
            if (app == null) return;
            for (var i = 0; i < pnlEditor.Controls.Count; i++)
                pnlEditor.Controls.RemoveAt(i);
            var uc = new UcAppEditor(app, breadcrumb);
            pnlEditor.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.Show();
        }

        private void ShowEditorControl(Credential credential, string breadCrumb)
        {
            if(credential==null)return;
            var uc = new UcCredentialEditor(credential, breadCrumb);
            for (var i = 0; i < pnlEditor.Controls.Count; i++)
                pnlEditor.Controls.RemoveAt(i);

            pnlEditor.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.Show();
        }
        /// <summary>
        /// Update any Node object before selection changes. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            var tv = sender as TreeView;
            if (tv == null) return;
            if (tv.SelectedNode == null) return;
            var node = tv.SelectedNode as KasteloTreeNode;
            if (node == null) return;

            // We have a valid object, so update the treeview object (Tag)
            // with the values from the editor panel, once we descover
            // which type it is.
            switch (node.Level)
            {
                case 0:
                    // Ensure an editor control is loaded.
                    if (!pnlEditor.Controls.ContainsKey("UcApplicationStoreEditor")) return;
                    // Update this node with any changes.
                    node.Tag = ((UcApplicationStoreEditor)pnlEditor.Controls.Find("UcApplicationStoreEditor", true)[0]).AppStore;
                    break;
                case 1:
                    // Ensure an editor control is loaded.
                    if (!pnlEditor.Controls.ContainsKey("ucAppEditor")) return;
                    // Update this node with any changes.
                    node.Tag = ((UcAppEditor)pnlEditor.Controls.Find("ucAppEditor", true)[0]).App;
                    break;
                case 2:
                    // Ensure an editor control is loaded.
                    if (!pnlEditor.Controls.ContainsKey("UcCredentialEditor")) return;
                    // Update this node with any changes.
                    node.Tag = ((UcCredentialEditor)pnlEditor.Controls.Find("UcCredentialEditor", true)[0]).Credential;
                    break;
                default:
                    return;
            }
            node.UpdateValues();
        }
        /// <summary>
        /// Saves data changes when treeview node changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Selection has changed, so reload the editor panel with correct type.
            var obj = e.Node as KasteloTreeNode;
            if (obj == null) return;
            if (obj.Tag == null) return;

            switch (obj.Level)
            {
                case 0:
                    ShowEditorControl(obj.Tag as ApplicationStore , obj.FullPath);
                    break;
                case 1:
                    ShowEditorControl(obj.Tag as App, obj.FullPath);
                    break;
                case 2:
                    ShowEditorControl(obj.Tag as Credential, obj.FullPath);
                    break;
            }
        }
        /// <summary>
        /// Decides if any changes needs to be saved 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveLocal_Click(object sender, EventArgs e)
        {
            var bNeedToSave = false;
            foreach (KasteloTreeNode node in treeView1.Nodes)
            {
                if (node.Haschanged)
                {
                    bNeedToSave = true;
                    break;
                }
                foreach (KasteloTreeNode subNode in node.Nodes)
                {
                    if (subNode.Haschanged)
                    {
                        bNeedToSave = true;
                        break;
                    }
                    if (subNode.Nodes.Cast<KasteloTreeNode>().Any(finalNode => finalNode.Haschanged))
                        bNeedToSave = true;
                }
            }
            if(bNeedToSave)
                SaveChanges();
        }
        /// <summary>
        /// Saves 
        /// </summary>
        private void SaveChanges()
        {
            // Build up a store from treeview.
            var strMgr = new ApplicationStore("New");
            foreach (KasteloTreeNode storeNode in treeView1.Nodes)
            {
                strMgr = storeNode.Tag as ApplicationStore;
                if (strMgr == null) return;
                
                // Has a password been set for this store?
                if (strMgr.Hash == null || strMgr.Hash.Length == 0)
                {
                    // Create a password has for this store.
                    strMgr.Hash = Helper.GetHashFromString("password");    
                }
                
                strMgr.Applications.Clear();
                foreach (KasteloTreeNode applicationNode in storeNode.Nodes)
                    strMgr.Applications.Add(applicationNode.Tag as App);
            }

            // Get path for save
            var fd = GetFileDialog(false);
            if (fd.ShowDialog() != DialogResult.OK) return;
            var initialisationVector = Convert.FromBase64String(Settings.Default.IV);
            var success = strMgr.Save(fd.FileName, initialisationVector);

            MessageBox.Show(success ? "Saved successfully" : "Save Failed!", Resources.Save_Store, MessageBoxButtons.OK,
                            success ?MessageBoxIcon.Information: MessageBoxIcon.Exclamation);
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            var fd = GetFileDialog(true);
            if (fd.ShowDialog() != DialogResult.OK) return;
            LoadFile(fd.FileName);
        }

        protected void LoadFile(string fileName)
        {
            try
            {
                var strMgr = new StoreManager("tmp");
                if (strMgr.Load(fileName, Convert.FromBase64String(Settings.Default.IV), Helper.PropmtForPassword()))
                {
                    treeView1.Nodes.Clear();
                    var treeNode = new KasteloTreeNode(strMgr);
                    treeView1.Nodes.Add(treeNode);
                    treeView1.Nodes[0].Expand();
                    treeView1.SelectedNode = treeView1.Nodes[0];
                    
                    // Store the filepath so it can be auto loaded next time.
                    Settings.Default.LastFile = fileName;
                    Settings.Default.Save();
                }
                else
                {
                    throw new AuthenticationException();
                }
            }
            catch (AuthenticationException)
            {
                MessageBox.Show(Resources.Sorry_password_entered_incorrect,
                                Resources.Incorrect_password,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show(Resources.Form1_btnLoadFromFile_ExceptionMsg, 
                    Resources.Form1_btnLoadFromFile_Unable_to_load_this_data_store, 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pnlEditor_Leave(object sender, EventArgs e)
        {
            // The editor panel has lost focus, ensure any changes made are reflected in the treeview
            treeView1_BeforeSelect(treeView1, 
                new TreeViewCancelEventArgs(treeView1.SelectedNode,false,TreeViewAction.ByKeyboard));
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var headingFont = new Font("Arial", 10, FontStyle.Bold);

            // Find the selected node
            var selectedNode = treeView1.SelectedNode as KasteloTreeNode;
            if (selectedNode == null)
            {                
                // There is no store yet, create one.
                var storeNode = new KasteloTreeNode(new ApplicationStore("[New]")){NodeFont = headingFont};
                treeView1.Nodes.Add(storeNode);
                treeView1.Refresh();
                treeView1.SelectedNode = storeNode;
                return;
            }

            // Find what type of node this is and add a new one / sub node to the treeview.
            switch (selectedNode.Level)
            {
                case 0: // ApplicationStore / StoreManagerLevel
                    var newAppNode = new KasteloTreeNode(new App("[New]")){NodeFont = headingFont};
                    selectedNode.Nodes.Add(newAppNode);
                    treeView1.SelectedNode = newAppNode;
                    break;
                case 1: // Application level
                    var newCredentialNode = new KasteloTreeNode(new Credential("[New]", ""));
                    selectedNode.Nodes.Add(newCredentialNode);
                    // NB: Credentials are also stored in the app node objects tag!
                    ((App)selectedNode.Tag).Credentials.Add(newCredentialNode.Tag as Credential);
                    treeView1.SelectedNode = newCredentialNode;
                    break;
                case 2: // Credential level 
                    var newCredential = new KasteloTreeNode(new Credential("[New]", ""));
                    selectedNode.Parent.Nodes.Add(newCredential);
                    treeView1.Refresh();
                    var parentObj = ((KasteloTreeNode)selectedNode.Parent).Tag as App;
                    if (parentObj != null) parentObj.Credentials.Add(newCredential.Tag as Credential);
                    treeView1.SelectedNode = newCredential;
                    break;
            }
            treeView1.Refresh();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            // Which node was selected?
            var selectedNode = treeView1.SelectedNode as KasteloTreeNode;
            if (selectedNode == null) return;

            // What type of node is it? We *may* need to edit its parent.
            switch (selectedNode.Level)
            {
                case 0: // ApplicationStore / StoreManagerLevel
                case 1: // Application level
                    break;
                case 2: // Credential level 
                        //- credentials also stored in the app node objects tag!
                    var app = ((KasteloTreeNode)selectedNode.Parent).Tag as App;
                    if (app != null) 
                        app.Remove(selectedNode.Tag as Credential);
                    break;
            }
            
            selectedNode.Remove();
            treeView1.Refresh();
            if(treeView1.Nodes.Count > 0)
                ((KasteloTreeNode) treeView1.Nodes[0]).Haschanged = true;
            
        }

        private static FileDialog GetFileDialog(bool load)
        {
            var fd = load ? (FileDialog) new OpenFileDialog() : new SaveFileDialog();
            fd.AddExtension = true;
            fd.FileName = "Store.bin";
            fd.DefaultExt = ".bin";
            fd.CheckPathExists = true;
            fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            fd.Filter = Resources.FileFilter;
            fd.RestoreDirectory = true;
            return fd;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var b = new AboutBox {StartPosition = FormStartPosition.CenterScreen};
            b.ShowDialog();

            // Only show load previous file dialog when there is a file to load!
            if (string.IsNullOrEmpty(Settings.Default.LastFile)) return;
            var dlgResult = MessageBox.Show(Resources.load_the_same_store,
                Resources.Reload_previous_item, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.Yes)
                LoadFile(Settings.Default.LastFile);
        }

        private void btnSetPassword_Click(object sender, EventArgs e)
        {
            if (treeView1.Nodes.Count == 0)
                return;

            var dlgResult = MessageBox.Show(Resources.Are_you_sure_password_change,
                Resources.Confirm_password_change,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (dlgResult.Equals(DialogResult.Yes))
            {
                var storeManager = ((KasteloTreeNode)treeView1.Nodes[0]).Tag as ApplicationStore;
                if (storeManager != null)
                    storeManager.Hash = Helper.PropmtForPassword();

                ((KasteloTreeNode) treeView1.Nodes[0]).Haschanged = true;

                MessageBox.Show(Resources.Password_changed_successfully,
                                Resources.Password_changed,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button1);

                btnSaveLocal_Click(null, null);
            }
        }

        private void pnlEditor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}   

    public static class Helper
    {
        /// <summary>
        /// Returns a populated application store object.
        /// </summary>
        /// <returns></returns>
        public static ApplicationStore BuildTempStore()
        {
            // Create an application store
            var myStore = new ApplicationStore("Test store");
            
            // Create an Application with some credentials
            var myApp = new App("App 1");
            myApp.Add(new Credential("App 1 Username1", "App 1 Password1"));
            myApp.Add(new Credential("App 1 Username2", "App 1 Password2"));
            // add to the store
            myStore.Add(myApp);

            // Create another Application with some credentials
            myApp = new App("App 2");
            myApp.Add(new Credential("App 2 Username1", "App 1 Password1"));
            myApp.Add(new Credential("App 2 Username2", "App 1 Password2"));

            // add to the store
            myStore.Add(myApp);

            return myStore;
        }

        public static void ResetSettingsKey()
        {
            byte[] iv = { 187, 201, 13, 144, 55, 116, 79, 18, 45, 10, 121, 44, 3, 124, 152, 164 };
            Settings.Default.IV = Convert.ToBase64String(iv);
            Console.WriteLine(Convert.ToBase64String(iv));
            Settings.Default.Save();
        }

        public static void SetupTreeview(TreeView treeview)
        {
            treeview.Nodes.Clear();
            var myStore = BuildTempStore();
            var treeNode = new KasteloTreeNode(myStore);
            treeview.Nodes.Add(treeNode);
            treeview.ExpandAll();
        }

        public static byte[] GetHashFromString(string cleartext)
        {
            HashAlgorithm sha = new SHA1CryptoServiceProvider();
            return sha.ComputeHash(Encoding.ASCII.GetBytes(cleartext));
        }

        public static byte[] PropmtForPassword()
        {
            HashAlgorithm sha = new SHA1CryptoServiceProvider();
            string a ="          ";
            ShowInputDialog(ref a);
            return sha.ComputeHash(Encoding.ASCII.GetBytes(a));
        }

        // ReSharper disable once UnusedMethodReturnValue.Local
        private static DialogResult ShowInputDialog(ref string input)
        {
            var size = new Size(250, 70);
            var inputBox = new Form
            {
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MinimizeBox = false,
                MaximizeBox = false,
                ClientSize = size,
                Text = Resources.Enter_Password
            };

            var textBox = new TextBox
            {
                Size = new Size(size.Width - 10, 23),
                Location = new Point(5, 5),
                Text = input,
                TextAlign = HorizontalAlignment.Center,
                PasswordChar = '*'
            };
            textBox.SelectAll();
            inputBox.Controls.Add(textBox);

            var okButton = new Button
            {
                DialogResult = DialogResult.OK,
                Name = "okButton",
                Size = new Size(75, 23),
                Text = @"&OK",
                Location = new Point(size.Width - 80 - 80, 39)
            };
            inputBox.Controls.Add(okButton);

            var cancelButton = new Button
            {
                DialogResult = DialogResult.Cancel,
                Name = "cancelButton",
                Size = new Size(75, 23),
                Text = @"&Cancel",
                Location = new Point(size.Width - 80, 39)
            };
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            var result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }
    }

