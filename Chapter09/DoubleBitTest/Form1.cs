using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleBitTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            byte[] bytes;
            double v;

            v = double.MaxValue;
            bytes = BitConverter.GetBytes(v);
            

        }

        string ShowBits(double v)
        {
            string result = "";
            byte[] bytes  = BitConverter.GetBytes(v);
            for (int i = 0; i < bytes.Length; i++)
            {
                result += " " + Convert.ToString(bytes[i], 2);
            }
            return result.Substring(1);
        }
    }
}
