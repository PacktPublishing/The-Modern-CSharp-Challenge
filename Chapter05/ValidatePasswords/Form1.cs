using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidatePasswords
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // See if the password meets the criteria.
        private void validateButton_Click(object sender, EventArgs e)
        {
            int minLength = int.Parse(minLengthTextBox.Text);
            int maxLength = int.Parse(maxLengthTextBox.Text);
            string password = passwordTextBox.Text;
            if (password.PasswordIsValid(minLength, maxLength,
                allowLowercaseCheckBox.Checked, requireLowercaseCheckBox.Checked,
                allowUppercaseCheckBox.Checked, requireUppercaseCheckBox.Checked,
                allowDigitCheckBox.Checked, requireDigitCheckBox.Checked,
                allowSpecialCheckBox.Checked, requireSpecialCheckBox.Checked,
                allowOtherCheckBox.Checked, requireOtherCheckBox.Checked,
                otherTextBox.Text))
                resultLabel.Text = "Password is valid";
            else
                resultLabel.Text = "Password is not valid";
        }
    }
}
