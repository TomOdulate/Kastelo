namespace Kastelo.Controls
{
    partial class UcPasswordGenerator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAdditionalChars = new System.Windows.Forms.TextBox();
            this.chkIncludeCharacters = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.numPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkAlphaNumeric = new System.Windows.Forms.CheckBox();
            this.chkSpecials1 = new System.Windows.Forms.CheckBox();
            this.chkSpecials2 = new System.Windows.Forms.CheckBox();
            this.chkPunctuation = new System.Windows.Forms.CheckBox();
            this.lblAlphaNumeric = new System.Windows.Forms.Label();
            this.lblPunctuation = new System.Windows.Forms.Label();
            this.lblSpecials1 = new System.Windows.Forms.Label();
            this.lblSpecials2 = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblBrackets = new System.Windows.Forms.Label();
            this.chkBrackets = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPasswordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lblBrackets);
            this.panel1.Controls.Add(this.chkBrackets);
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Controls.Add(this.lblSpecials2);
            this.panel1.Controls.Add(this.lblSpecials1);
            this.panel1.Controls.Add(this.lblPunctuation);
            this.panel1.Controls.Add(this.lblAlphaNumeric);
            this.panel1.Controls.Add(this.chkPunctuation);
            this.panel1.Controls.Add(this.chkSpecials2);
            this.panel1.Controls.Add(this.chkSpecials1);
            this.panel1.Controls.Add(this.chkAlphaNumeric);
            this.panel1.Controls.Add(this.txtAdditionalChars);
            this.panel1.Controls.Add(this.chkIncludeCharacters);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnDone);
            this.panel1.Controls.Add(this.txtNewPassword);
            this.panel1.Controls.Add(this.numPasswordLength);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Location = new System.Drawing.Point(9, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 206);
            this.panel1.TabIndex = 10;
            // 
            // txtAdditionalChars
            // 
            this.txtAdditionalChars.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdditionalChars.Location = new System.Drawing.Point(103, 173);
            this.txtAdditionalChars.Name = "txtAdditionalChars";
            this.txtAdditionalChars.Size = new System.Drawing.Size(65, 29);
            this.txtAdditionalChars.TabIndex = 13;
            this.txtAdditionalChars.Visible = false;
            this.txtAdditionalChars.TextChanged += new System.EventHandler(this.txtDisallowedChars_TextChanged);
            // 
            // chkIncludeCharacters
            // 
            this.chkIncludeCharacters.AutoSize = true;
            this.chkIncludeCharacters.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIncludeCharacters.Location = new System.Drawing.Point(46, 174);
            this.chkIncludeCharacters.Name = "chkIncludeCharacters";
            this.chkIncludeCharacters.Size = new System.Drawing.Size(52, 17);
            this.chkIncludeCharacters.TabIndex = 12;
            this.chkIncludeCharacters.Text = "Other";
            this.chkIncludeCharacters.UseVisualStyleBackColor = true;
            this.chkIncludeCharacters.CheckedChanged += new System.EventHandler(this.chkDisallowedCharacters_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(302, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 53);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(402, 150);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(94, 53);
            this.btnDone.TabIndex = 5;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.CausesValidation = false;
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(3, 9);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(493, 26);
            this.txtNewPassword.TabIndex = 3;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // numPasswordLength
            // 
            this.numPasswordLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPasswordLength.Location = new System.Drawing.Point(371, 63);
            this.numPasswordLength.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numPasswordLength.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numPasswordLength.Name = "numPasswordLength";
            this.numPasswordLength.Size = new System.Drawing.Size(125, 53);
            this.numPasswordLength.TabIndex = 1;
            this.numPasswordLength.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 34);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(493, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(202, 150);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(94, 53);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Generate a new password";
            // 
            // chkAlphaNumeric
            // 
            this.chkAlphaNumeric.AutoSize = true;
            this.chkAlphaNumeric.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAlphaNumeric.Checked = true;
            this.chkAlphaNumeric.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAlphaNumeric.Location = new System.Drawing.Point(3, 84);
            this.chkAlphaNumeric.Name = "chkAlphaNumeric";
            this.chkAlphaNumeric.Size = new System.Drawing.Size(95, 17);
            this.chkAlphaNumeric.TabIndex = 14;
            this.chkAlphaNumeric.Text = "Alpha Numeric";
            this.chkAlphaNumeric.UseVisualStyleBackColor = true;
            this.chkAlphaNumeric.CheckedChanged += new System.EventHandler(this.chkAlphaNumeric_CheckedChanged);
            // 
            // chkSpecials1
            // 
            this.chkSpecials1.AutoSize = true;
            this.chkSpecials1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSpecials1.Checked = true;
            this.chkSpecials1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSpecials1.Location = new System.Drawing.Point(23, 138);
            this.chkSpecials1.Name = "chkSpecials1";
            this.chkSpecials1.Size = new System.Drawing.Size(75, 17);
            this.chkSpecials1.TabIndex = 15;
            this.chkSpecials1.Text = "Specials 1";
            this.chkSpecials1.UseVisualStyleBackColor = true;
            this.chkSpecials1.CheckedChanged += new System.EventHandler(this.chkSpecials1_CheckedChanged);
            // 
            // chkSpecials2
            // 
            this.chkSpecials2.AutoSize = true;
            this.chkSpecials2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSpecials2.Location = new System.Drawing.Point(28, 156);
            this.chkSpecials2.Name = "chkSpecials2";
            this.chkSpecials2.Size = new System.Drawing.Size(70, 17);
            this.chkSpecials2.TabIndex = 16;
            this.chkSpecials2.Text = "Special 2";
            this.chkSpecials2.UseVisualStyleBackColor = true;
            this.chkSpecials2.CheckedChanged += new System.EventHandler(this.chkSpecials2_CheckedChanged);
            // 
            // chkPunctuation
            // 
            this.chkPunctuation.AutoSize = true;
            this.chkPunctuation.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPunctuation.Location = new System.Drawing.Point(15, 120);
            this.chkPunctuation.Name = "chkPunctuation";
            this.chkPunctuation.Size = new System.Drawing.Size(83, 17);
            this.chkPunctuation.TabIndex = 17;
            this.chkPunctuation.Text = "Punctuation";
            this.chkPunctuation.UseVisualStyleBackColor = true;
            this.chkPunctuation.CheckedChanged += new System.EventHandler(this.chkPunctuation_CheckedChanged);
            // 
            // lblAlphaNumeric
            // 
            this.lblAlphaNumeric.AutoSize = true;
            this.lblAlphaNumeric.Location = new System.Drawing.Point(104, 85);
            this.lblAlphaNumeric.Name = "lblAlphaNumeric";
            this.lblAlphaNumeric.Size = new System.Drawing.Size(103, 13);
            this.lblAlphaNumeric.TabIndex = 18;
            this.lblAlphaNumeric.Text = "Letters and numbers";
            this.lblAlphaNumeric.Click += new System.EventHandler(this.lblAlphaNumeric_Click);
            // 
            // lblPunctuation
            // 
            this.lblPunctuation.AutoSize = true;
            this.lblPunctuation.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunctuation.Location = new System.Drawing.Point(104, 121);
            this.lblPunctuation.Name = "lblPunctuation";
            this.lblPunctuation.Size = new System.Drawing.Size(49, 13);
            this.lblPunctuation.TabIndex = 19;
            this.lblPunctuation.Text = "label3";
            this.lblPunctuation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPunctuation.Click += new System.EventHandler(this.lblPunctuation_Click);
            // 
            // lblSpecials1
            // 
            this.lblSpecials1.AutoSize = true;
            this.lblSpecials1.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecials1.Location = new System.Drawing.Point(104, 139);
            this.lblSpecials1.Name = "lblSpecials1";
            this.lblSpecials1.Size = new System.Drawing.Size(49, 13);
            this.lblSpecials1.TabIndex = 20;
            this.lblSpecials1.Text = "label4";
            this.lblSpecials1.Click += new System.EventHandler(this.lblSpecials1_Click);
            // 
            // lblSpecials2
            // 
            this.lblSpecials2.AutoSize = true;
            this.lblSpecials2.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecials2.Location = new System.Drawing.Point(104, 157);
            this.lblSpecials2.Name = "lblSpecials2";
            this.lblSpecials2.Size = new System.Drawing.Size(49, 13);
            this.lblSpecials2.TabIndex = 21;
            this.lblSpecials2.Text = "label5";
            this.lblSpecials2.Click += new System.EventHandler(this.lblSpecials2_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(5, 64);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(187, 17);
            this.lblHeading.TabIndex = 22;
            this.lblHeading.Text = "Include these characters";
            this.lblHeading.Click += new System.EventHandler(this.lblHeading_Click);
            // 
            // lblBrackets
            // 
            this.lblBrackets.AutoSize = true;
            this.lblBrackets.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrackets.Location = new System.Drawing.Point(104, 103);
            this.lblBrackets.Name = "lblBrackets";
            this.lblBrackets.Size = new System.Drawing.Size(49, 13);
            this.lblBrackets.TabIndex = 24;
            this.lblBrackets.Text = "label4";
            // 
            // chkBrackets
            // 
            this.chkBrackets.AutoSize = true;
            this.chkBrackets.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBrackets.Checked = true;
            this.chkBrackets.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBrackets.Location = new System.Drawing.Point(30, 102);
            this.chkBrackets.Name = "chkBrackets";
            this.chkBrackets.Size = new System.Drawing.Size(68, 17);
            this.chkBrackets.TabIndex = 23;
            this.chkBrackets.Text = "Brackets";
            this.chkBrackets.UseVisualStyleBackColor = true;
            // 
            // UcPasswordGenerator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "UcPasswordGenerator";
            this.Padding = new System.Windows.Forms.Padding(70, 55, 55, 55);
            this.Size = new System.Drawing.Size(516, 242);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPasswordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.NumericUpDown numPasswordLength;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdditionalChars;
        private System.Windows.Forms.CheckBox chkIncludeCharacters;
        private System.Windows.Forms.CheckBox chkPunctuation;
        private System.Windows.Forms.CheckBox chkSpecials2;
        private System.Windows.Forms.CheckBox chkSpecials1;
        private System.Windows.Forms.CheckBox chkAlphaNumeric;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblSpecials2;
        private System.Windows.Forms.Label lblSpecials1;
        private System.Windows.Forms.Label lblPunctuation;
        private System.Windows.Forms.Label lblAlphaNumeric;
        private System.Windows.Forms.Label lblBrackets;
        private System.Windows.Forms.CheckBox chkBrackets;
    }
}
