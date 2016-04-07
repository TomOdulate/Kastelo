namespace Kastelo.Controls
{
    partial class UcCredentialEditor
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chkShowPasswordCharacters = new System.Windows.Forms.CheckBox();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.btnCopyUsernameToClipboard = new System.Windows.Forms.Button();
            this.btnCopyPasswordToClipboard = new System.Windows.Forms.Button();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.lblLastUpdatedDate = new System.Windows.Forms.Label();
            this.txtLastUpdatedDate = new System.Windows.Forms.TextBox();
            this.txtCreatedDate = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.credentialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ucCredentialEditorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.credentialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucCredentialEditorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chkShowPasswordCharacters
            // 
            this.chkShowPasswordCharacters.AutoSize = true;
            this.chkShowPasswordCharacters.Location = new System.Drawing.Point(295, 102);
            this.chkShowPasswordCharacters.Name = "chkShowPasswordCharacters";
            this.chkShowPasswordCharacters.Size = new System.Drawing.Size(53, 17);
            this.chkShowPasswordCharacters.TabIndex = 5;
            this.chkShowPasswordCharacters.Text = "Show";
            this.chkShowPasswordCharacters.UseVisualStyleBackColor = true;
            this.chkShowPasswordCharacters.CheckedChanged += new System.EventHandler(this.chkShowPasswordCharacters_CheckedChanged);
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Location = new System.Drawing.Point(219, 99);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(70, 46);
            this.btnGeneratePassword.TabIndex = 6;
            this.btnGeneratePassword.Text = "Generate Password";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // btnCopyUsernameToClipboard
            // 
            this.btnCopyUsernameToClipboard.Location = new System.Drawing.Point(468, 47);
            this.btnCopyUsernameToClipboard.Name = "btnCopyUsernameToClipboard";
            this.btnCopyUsernameToClipboard.Size = new System.Drawing.Size(40, 20);
            this.btnCopyUsernameToClipboard.TabIndex = 2;
            this.btnCopyUsernameToClipboard.Text = "Copy";
            this.btnCopyUsernameToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyUsernameToClipboard.Click += new System.EventHandler(this.btnCopyUsernameToClipboard_Click);
            // 
            // btnCopyPasswordToClipboard
            // 
            this.btnCopyPasswordToClipboard.Location = new System.Drawing.Point(468, 74);
            this.btnCopyPasswordToClipboard.Name = "btnCopyPasswordToClipboard";
            this.btnCopyPasswordToClipboard.Size = new System.Drawing.Size(40, 20);
            this.btnCopyPasswordToClipboard.TabIndex = 4;
            this.btnCopyPasswordToClipboard.Text = "Copy";
            this.btnCopyPasswordToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyPasswordToClipboard.Click += new System.EventHandler(this.btnCopyPasswordToClipboard_Click);
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Location = new System.Drawing.Point(36, 102);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(47, 13);
            this.lblCreatedDate.TabIndex = 33;
            this.lblCreatedDate.Text = "Created:";
            // 
            // lblLastUpdatedDate
            // 
            this.lblLastUpdatedDate.AutoSize = true;
            this.lblLastUpdatedDate.Location = new System.Drawing.Point(12, 128);
            this.lblLastUpdatedDate.Name = "lblLastUpdatedDate";
            this.lblLastUpdatedDate.Size = new System.Drawing.Size(71, 13);
            this.lblLastUpdatedDate.TabIndex = 32;
            this.lblLastUpdatedDate.Text = "LastUpdated:";
            // 
            // txtLastUpdatedDate
            // 
            this.txtLastUpdatedDate.Enabled = false;
            this.txtLastUpdatedDate.Location = new System.Drawing.Point(85, 125);
            this.txtLastUpdatedDate.Name = "txtLastUpdatedDate";
            this.txtLastUpdatedDate.Size = new System.Drawing.Size(128, 20);
            this.txtLastUpdatedDate.TabIndex = 31;
            this.txtLastUpdatedDate.TabStop = false;
            this.txtLastUpdatedDate.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // txtCreatedDate
            // 
            this.txtCreatedDate.Enabled = false;
            this.txtCreatedDate.Location = new System.Drawing.Point(85, 99);
            this.txtCreatedDate.Name = "txtCreatedDate";
            this.txtCreatedDate.Size = new System.Drawing.Size(128, 20);
            this.txtCreatedDate.TabIndex = 30;
            this.txtCreatedDate.TabStop = false;
            this.txtCreatedDate.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(25, 50);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(58, 13);
            this.lblUserName.TabIndex = 29;
            this.lblUserName.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(27, 76);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 28;
            this.lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.credentialBindingSource, "Username", true));
            this.txtUsername.Location = new System.Drawing.Point(85, 47);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(377, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // credentialBindingSource
            // 
            this.credentialBindingSource.DataSource = typeof(Tao.CredentialStore.Credential);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(85, 73);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(377, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 38;
            this.label1.Text = "Application Editor";
            // 
            // ucCredentialEditorBindingSource
            // 
            this.ucCredentialEditorBindingSource.DataSource = typeof(Kastelo.Controls.UcCredentialEditor);
            // 
            // UcCredentialEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkShowPasswordCharacters);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.btnCopyUsernameToClipboard);
            this.Controls.Add(this.btnCopyPasswordToClipboard);
            this.Controls.Add(this.lblCreatedDate);
            this.Controls.Add(this.lblLastUpdatedDate);
            this.Controls.Add(this.txtLastUpdatedDate);
            this.Controls.Add(this.txtCreatedDate);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Name = "UcCredentialEditor";
            this.Size = new System.Drawing.Size(517, 182);
            ((System.ComponentModel.ISupportInitialize)(this.credentialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucCredentialEditorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkShowPasswordCharacters;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.Button btnCopyUsernameToClipboard;
        private System.Windows.Forms.Button btnCopyPasswordToClipboard;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label lblLastUpdatedDate;
        private System.Windows.Forms.TextBox txtLastUpdatedDate;
        private System.Windows.Forms.TextBox txtCreatedDate;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.BindingSource credentialBindingSource;
        private System.Windows.Forms.BindingSource ucCredentialEditorBindingSource;
        private System.Windows.Forms.Label label1;
    }
}
