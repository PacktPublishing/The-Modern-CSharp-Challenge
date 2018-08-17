using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomItems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] Animals;
        private List<string> Foods;

        // Make the array and list of items.
        private void Form1_Load(object sender, EventArgs e)
        {
            Animals = new string[]
            {
                "Ape", "Bear", "Cat", "Dolphin", "Eagle", "Frog",
                "Giraffe", "Hippopotamus", "Iguana", "Jackal", "Kangaroo",
                "Llama", "Monkey", "Newt", "Owl", "Peacock", "Quail",
                "Rat", "Snake", "Turtle", "Unicorn", "Vulture",
                "Warthog", "Xerus", "Yak", "Zebra"
            };

            Foods = new List<string>(new string[]
            {
                "Apple", "Banana", "Cream", "Date", "Endive", "Fig",
                "Grape", "Horseradish", "Ice Cream", "Jelly", "Kumquat",
                "Lemon", "Mushroom", "Noodles", "Omelet", "Peas", "Quiche",
                "Rice", "Sandwich", "Tea", "Udon", "Venison",
                "Watermelon", "Xacuti", "Yam", "Zucchini"
            });
        }

        // Select a random animal and food.
        private void selectButton_Click(object sender, EventArgs e)
        {
            arrayItemTextBox.Text = Animals.Random();
            listItemTextBox.Text = Foods.Random();
        }
    }
}
