namespace Kastelo
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pnlEditor = new System.Windows.Forms.Panel();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.pnlControlsSubPanel = new System.Windows.Forms.Panel();
            this.btnSetPassword = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnSaveLocal = new System.Windows.Forms.Button();
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.pnlControls.SuspendLayout();
            this.pnlControlsSubPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.HideSelection = false;
            this.treeView1.HotTracking = true;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(302, 209);
            this.treeView1.TabIndex = 0;
            this.treeView1.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeSelect);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // pnlEditor
            // 
            this.pnlEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEditor.Location = new System.Drawing.Point(303, 0);
            this.pnlEditor.Name = "pnlEditor";
            this.pnlEditor.Size = new System.Drawing.Size(531, 262);
            this.pnlEditor.TabIndex = 1;
            this.pnlEditor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEditor_Paint);
            this.pnlEditor.Leave += new System.EventHandler(this.pnlEditor_Leave);
            // 
            // pnlControls
            // 
            this.pnlControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControls.Controls.Add(this.pnlControlsSubPanel);
            this.pnlControls.Controls.Add(this.treeView1);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(304, 262);
            this.pnlControls.TabIndex = 28;
            // 
            // pnlControlsSubPanel
            // 
            this.pnlControlsSubPanel.Controls.Add(this.btnSetPassword);
            this.pnlControlsSubPanel.Controls.Add(this.btnDeleteItem);
            this.pnlControlsSubPanel.Controls.Add(this.btnAddItem);
            this.pnlControlsSubPanel.Controls.Add(this.btnSaveLocal);
            this.pnlControlsSubPanel.Controls.Add(this.btnLoadFromFile);
            this.pnlControlsSubPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControlsSubPanel.Location = new System.Drawing.Point(0, 209);
            this.pnlControlsSubPanel.Name = "pnlControlsSubPanel";
            this.pnlControlsSubPanel.Size = new System.Drawing.Size(302, 51);
            this.pnlControlsSubPanel.TabIndex = 140;
            // 
            // btnSetPassword
            // 
            this.btnSetPassword.Location = new System.Drawing.Point(125, 5);
            this.btnSetPassword.Name = "btnSetPassword";
            this.btnSetPassword.Size = new System.Drawing.Size(51, 35);
            this.btnSetPassword.TabIndex = 181;
            this.btnSetPassword.Text = "Set Pass";
            this.btnSetPassword.UseVisualStyleBackColor = true;
            this.btnSetPassword.Click += new System.EventHandler(this.btnSetPassword_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(64, 5);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(51, 35);
            this.btnDeleteItem.TabIndex = 160;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(3, 5);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(51, 35);
            this.btnAddItem.TabIndex = 150;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnSaveLocal
            // 
            this.btnSaveLocal.Location = new System.Drawing.Point(247, 5);
            this.btnSaveLocal.Name = "btnSaveLocal";
            this.btnSaveLocal.Size = new System.Drawing.Size(51, 35);
            this.btnSaveLocal.TabIndex = 180;
            this.btnSaveLocal.Text = "Save";
            this.btnSaveLocal.UseVisualStyleBackColor = true;
            this.btnSaveLocal.Click += new System.EventHandler(this.btnSaveLocal_Click);
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.Location = new System.Drawing.Point(186, 5);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(51, 35);
            this.btnLoadFromFile.TabIndex = 170;
            this.btnLoadFromFile.Text = "Load";
            this.btnLoadFromFile.UseVisualStyleBackColor = true;
            this.btnLoadFromFile.Click += new System.EventHandler(this.btnLoadFromFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 262);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlEditor);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(855, 301);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(850, 301);
            this.Name = "Form1";
            this.Text = "Kastelo Desktop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlControls.ResumeLayout(false);
            this.pnlControlsSubPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel pnlEditor;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Panel pnlControlsSubPanel;
        private System.Windows.Forms.Button btnSaveLocal;
        private System.Windows.Forms.Button btnLoadFromFile;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnSetPassword;
    }
}

