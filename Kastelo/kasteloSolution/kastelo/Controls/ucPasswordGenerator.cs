using System;
using System.Windows.Forms;
using Tao.CredentialStore;
using Kastelo.Utils;

namespace Kastelo.Controls
{
    public partial class UcPasswordGenerator : UserControl
    {
        private CharacterManager _cm = new CharacterManager();

        public string Password { get; set; }
        public bool Cancelled = false;

        public UcPasswordGenerator()
        {
            InitializeComponent();
            btnDone.Enabled = false;

            lblAlphaNumeric.Text = "Letters && numbers";
            lblPunctuation.Text = _cm.strPunctuation;
            lblBrackets.Text = _cm.strBrackets;
            lblSpecials1.Text = _cm.strSpecials1;
            lblSpecials2.Text = _cm.strSpecials2;
            
            btnGenerate_Click(null, null);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            _cm.AlphaNumeric(chkAlphaNumeric.Checked);
            _cm.Punctuation(chkPunctuation.Checked);
            _cm.Brackets(chkBrackets.Checked);
            _cm.Specials1(chkSpecials1.Checked);
            _cm.Specials2(chkSpecials2.Checked);
            var additionals = (chkIncludeCharacters.Checked)?txtAdditionalChars.Text:"";

            try
            {
                txtNewPassword.Text = PasswordGenerator.GeneratePassword(_cm.GenerateAllowableCharsArray(additionals)
                                                                        , (short)numPasswordLength.Value);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("No characters are selected");
            }
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            btnDone.Enabled = true;
            Password = txtNewPassword.Text;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Hide();
            Parent.Controls.Find("txtPassword", true)[0].Text = Password;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancelled = true;
            Hide();
        }

        private void chkDisallowedCharacters_CheckedChanged(object sender, EventArgs e)
        {
            var chkBox = sender as CheckBox;
            if (chkBox != null) txtAdditionalChars.Visible = chkBox.Checked;
        }

        private void txtDisallowedChars_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSpecials2_Click(object sender, EventArgs e)
        {

        }

        private void lblSpecials1_Click(object sender, EventArgs e)
        {

        }

        private void lblPunctuation_Click(object sender, EventArgs e)
        {

        }

        private void lblAlphaNumeric_Click(object sender, EventArgs e)
        {

        }

        private void chkPunctuation_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkSpecials2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkSpecials1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkAlphaNumeric_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }
    }
}
