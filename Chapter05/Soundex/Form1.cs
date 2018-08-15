using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soundex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Digits for characters.
        private Dictionary<char, char> LetterCodes;

        // Make the character lookup table.
        private void Form1_Load(object sender, EventArgs e)
        {
            LetterCodes = new Dictionary<char, char>();
            LetterCodes.Add('B', '1');
            LetterCodes.Add('F', '1');
            LetterCodes.Add('P', '1');
            LetterCodes.Add('V', '1');
            LetterCodes.Add('C', '2');
            LetterCodes.Add('G', '2');
            LetterCodes.Add('J', '2');
            LetterCodes.Add('K', '2');
            LetterCodes.Add('Q', '2');
            LetterCodes.Add('S', '2');
            LetterCodes.Add('X', '2');
            LetterCodes.Add('Z', '2');
            LetterCodes.Add('D', '3');
            LetterCodes.Add('T', '3');
            LetterCodes.Add('L', '4');
            LetterCodes.Add('M', '5');
            LetterCodes.Add('N', '5');
            LetterCodes.Add('R', '6');
        }

        // Display the name's Soundex encoding.
        private void encodeButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            encodingTextBox.Text = name.ToSoundex();
        }
    }
}
