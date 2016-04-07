namespace Kastelo.Controls
{
    partial class UcAppEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.lblLastUpdatedDate = new System.Windows.Forms.Label();
            this.txtLastUpdatedDate = new System.Windows.Forms.TextBox();
            this.txtCreatedDate = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Application Editor";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Location = new System.Drawing.Point(63, 120);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(47, 13);
            this.lblCreatedDate.TabIndex = 45;
            this.lblCreatedDate.Text = "Created:";
            // 
            // lblLastUpdatedDate
            // 
            this.lblLastUpdatedDate.AutoSize = true;
            this.lblLastUpdatedDate.Location = new System.Drawing.Point(39, 146);
            this.lblLastUpdatedDate.Name = "lblLastUpdatedDate";
            this.lblLastUpdatedDate.Size = new System.Drawing.Size(71, 13);
            this.lblLastUpdatedDate.TabIndex = 44;
            this.lblLastUpdatedDate.Text = "LastUpdated:";
            // 
            // txtLastUpdatedDate
            // 
            this.txtLastUpdatedDate.Enabled = false;
            this.txtLastUpdatedDate.Location = new System.Drawing.Point(112, 143);
            this.txtLastUpdatedDate.Name = "txtLastUpdatedDate";
            this.txtLastUpdatedDate.Size = new System.Drawing.Size(128, 20);
            this.txtLastUpdatedDate.TabIndex = 3;
            this.txtLastUpdatedDate.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // txtCreatedDate
            // 
            this.txtCreatedDate.Enabled = false;
            this.txtCreatedDate.Location = new System.Drawing.Point(112, 117);
            this.txtCreatedDate.Name = "txtCreatedDate";
            this.txtCreatedDate.Size = new System.Drawing.Size(128, 20);
            this.txtCreatedDate.TabIndex = 2;
            this.txtCreatedDate.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(93, 13);
            this.lblName.TabIndex = 41;
            this.lblName.Text = "Application Name:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(112, 47);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(323, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(71, 74);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(38, 13);
            this.lblNotes.TabIndex = 47;
            this.lblNotes.Text = "Notes:";
            this.lblNotes.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(112, 71);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(323, 40);
            this.txtNotes.TabIndex = 46;
            this.txtNotes.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // ucAppEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblCreatedDate);
            this.Controls.Add(this.lblLastUpdatedDate);
            this.Controls.Add(this.txtLastUpdatedDate);
            this.Controls.Add(this.txtCreatedDate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Name = "UcAppEditor";
            this.Size = new System.Drawing.Size(473, 171);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label lblLastUpdatedDate;
        private System.Windows.Forms.TextBox txtLastUpdatedDate;
        private System.Windows.Forms.TextBox txtCreatedDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
    }
}
