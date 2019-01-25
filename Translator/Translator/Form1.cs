using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Translator
{
    public partial class Form1 : Form
    {
        public string text2translate;
        public string result;

        public Form1()
        {
            InitializeComponent();
        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Replace("A", "[0]");
            textBox1.Text = textBox1.Text.Replace("a", "[0]");
            textBox1.Text = textBox1.Text.Replace("B", "[1]");
            textBox1.Text = textBox1.Text.Replace("b", "[1]");
            textBox1.Text = textBox1.Text.Replace("C", "[2]");
            textBox1.Text = textBox1.Text.Replace("c", "[2]");
            textBox1.Text = textBox1.Text.Replace("D", "[3]");
            textBox1.Text = textBox1.Text.Replace("d", "[3]");
            textBox1.Text = textBox1.Text.Replace("E", "[4]");
            textBox1.Text = textBox1.Text.Replace("e", "[4]");
            textBox1.Text = textBox1.Text.Replace("F", "[5]");
            textBox1.Text = textBox1.Text.Replace("f", "[5]");
            textBox1.Text = textBox1.Text.Replace("G", "[6]");
            textBox1.Text = textBox1.Text.Replace("g", "[6]");
            textBox1.Text = textBox1.Text.Replace("H", "[7]");
            textBox1.Text = textBox1.Text.Replace("h", "[7]");
            textBox1.Text = textBox1.Text.Replace("I", "[8]");
            textBox1.Text = textBox1.Text.Replace("i", "[8]");
            textBox1.Text = textBox1.Text.Replace("J", "[9]");
            textBox1.Text = textBox1.Text.Replace("j", "[9]");
            textBox1.Text = textBox1.Text.Replace("K", "(10)");
            textBox1.Text = textBox1.Text.Replace("k", "(10)");
            textBox1.Text = textBox1.Text.Replace("L", "(11)");
            textBox1.Text = textBox1.Text.Replace("l", "(11)");
            textBox1.Text = textBox1.Text.Replace("M", "(12)");
            textBox1.Text = textBox1.Text.Replace("m", "(12)");
            textBox1.Text = textBox1.Text.Replace("N", "(13)");
            textBox1.Text = textBox1.Text.Replace("n", "(13)");
            textBox1.Text = textBox1.Text.Replace("O", "(14)");
            textBox1.Text = textBox1.Text.Replace("o", "(14)");
            textBox1.Text = textBox1.Text.Replace("P", "(15)");
            textBox1.Text = textBox1.Text.Replace("p", "(15)");
            textBox1.Text = textBox1.Text.Replace("Q", "(16)");
            textBox1.Text = textBox1.Text.Replace("q", "(16)");
            textBox1.Text = textBox1.Text.Replace("R", "(17)");
            textBox1.Text = textBox1.Text.Replace("r", "(17)");
            textBox1.Text = textBox1.Text.Replace("S", "(18)");
            textBox1.Text = textBox1.Text.Replace("s", "(18)");
            textBox1.Text = textBox1.Text.Replace("T", "(19)");
            textBox1.Text = textBox1.Text.Replace("t", "(19)");
            textBox1.Text = textBox1.Text.Replace("U", "(20)");
            textBox1.Text = textBox1.Text.Replace("u", "(20)");
            textBox1.Text = textBox1.Text.Replace("V", "(21)");
            textBox1.Text = textBox1.Text.Replace("v", "(21)");
            textBox1.Text = textBox1.Text.Replace("W", "(22)");
            textBox1.Text = textBox1.Text.Replace("w", "(22)");
            textBox1.Text = textBox1.Text.Replace("X", "(23)");
            textBox1.Text = textBox1.Text.Replace("x", "(23)");
            textBox1.Text = textBox1.Text.Replace("Y", "(24)");
            textBox1.Text = textBox1.Text.Replace("y", "(24)");
            textBox1.Text = textBox1.Text.Replace("Z", "(25)");
            textBox1.Text = textBox1.Text.Replace("z", "(25)");
        }

        private void translateText_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Replace("[0]", "A");
            textBox1.Text = textBox1.Text.Replace("[1]", "B");
            textBox1.Text = textBox1.Text.Replace("[2]", "C");
            textBox1.Text = textBox1.Text.Replace("[3]", "D");
            textBox1.Text = textBox1.Text.Replace("[4]", "E");
            textBox1.Text = textBox1.Text.Replace("[5]", "F");
            textBox1.Text = textBox1.Text.Replace("[6]", "G");
            textBox1.Text = textBox1.Text.Replace("[7]", "H");
            textBox1.Text = textBox1.Text.Replace("[8]", "I");
            textBox1.Text = textBox1.Text.Replace("[9]", "J");
            textBox1.Text = textBox1.Text.Replace("(10)", "K");
            textBox1.Text = textBox1.Text.Replace("(11)", "L");
            textBox1.Text = textBox1.Text.Replace("(12)", "M");
            textBox1.Text = textBox1.Text.Replace("(13)", "N");
            textBox1.Text = textBox1.Text.Replace("(14)", "O");
            textBox1.Text = textBox1.Text.Replace("(15)", "P");
            textBox1.Text = textBox1.Text.Replace("(16)", "Q");
            textBox1.Text = textBox1.Text.Replace("(17)", "R");
            textBox1.Text = textBox1.Text.Replace("(18)", "S");
            textBox1.Text = textBox1.Text.Replace("(19)", "T");
            textBox1.Text = textBox1.Text.Replace("(20)", "U");
            textBox1.Text = textBox1.Text.Replace("(21)", "V");
            textBox1.Text = textBox1.Text.Replace("(22)", "W");
            textBox1.Text = textBox1.Text.Replace("(23)", "X");
            textBox1.Text = textBox1.Text.Replace("(24)", "Y");
            textBox1.Text = textBox1.Text.Replace("(25)", "Z");
        }
    }
}
