using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomPasswords
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Generate a random password.
        private void generateButton_Click(object sender, EventArgs e)
        {
            int minLength = int.Parse(minLengthTextBox.Text);
            int maxLength = int.Parse(maxLengthTextBox.Text);
            passwordTextBox.Text = RandomPassword(
                minLength, maxLength,
                allowLowercaseCheckBox.Checked, requireLowercaseCheckBox.Checked,
                allowUppercaseCheckBox.Checked, requireUppercaseCheckBox.Checked,
                allowDigitCheckBox.Checked, requireDigitCheckBox.Checked,
                allowSpecialCheckBox.Checked, requireSpecialCheckBox.Checked,
                allowOtherCheckBox.Checked, requireOtherCheckBox.Checked,
                otherTextBox.Text);
        }

        // Make a random password.
        private Random Rand = new Random();
        private string RandomPassword(
            int minLength, int maxLength,
            bool allowLowercase, bool requireLowercase,
            bool allowUppercase, bool requireUppercase,
            bool allowDigit, bool requireDigit,
            bool allowSpecial, bool requireSpecial,
            bool allowOther, bool requireOther, string other)
        {
            const string lowers = "abcdefghijklmnopqrstuvwxyz";
            const string uppers = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string digits = "0123456789";
            const string specials = @"~!@#$%^&*():;[]{}<>,.?/\|";

            // Make a string containing all allowed characters.
            string allowed = "";
            if (allowLowercase) allowed += lowers;
            if (allowUppercase) allowed += uppers;
            if (allowDigit) allowed += digits;
            if (allowSpecial) allowed += specials;
            if (allowOther) allowed += other;

            // Pick the number of characters.
            int passwordLength = Rand.Next(minLength, maxLength + 1);

            // Satisfy the requirements.
            string password = "";
            if (requireLowercase) password += lowers.ToCharArray().Random();
            if (requireUppercase) password += uppers.ToCharArray().Random();
            if (requireDigit) password += digits.ToCharArray().Random();
            if (requireSpecial) password += specials.ToCharArray().Random();
            if (requireOther) password += other.ToCharArray().Random();

            // Add the remaining characters randomly.
            while (password.Length < passwordLength)
                password += allowed.ToCharArray().Random();

            // Randomize so the required characters don't all appear at the front.
            char[] chars = password.ToCharArray();
            chars.Randomize();
            return new string(chars);
        }
    }
}
