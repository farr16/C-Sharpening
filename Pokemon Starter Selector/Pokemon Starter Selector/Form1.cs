using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_Starter_Selector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Generation 1 (Red, Blue, Green, Fire Red, Leaf Green)");
            listBox1.Items.Add("Generation 2 (Gold, Silver, Crystal, Heart Gold, Soul Silver)");
            listBox1.Items.Add("Generation 3 (Ruby, Sapphire, Emerald, Alpha Sapphire, Omega Ruby)");
            listBox1.Items.Add("Generation 4 (Diamond, Pearl)");
            listBox1.Items.Add("Generation 5 (Black, White, Black 2, White 2)");
            listBox1.Items.Add("Generation 6 (X, Y)");
            listBox1.Items.Add("Generation 7 (Sun, Moon)");
            listBox1.Items.Add("Custom");
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = "Selected: " + listBox1.SelectedIndex; 
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            label2.Text = "Generation " + (index + 1);
            label3.Text = "Generation " + (index + 1);
            label4.Text = "Generation " + (index + 1);

            if(index == 7)
            {
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
            }
        }
    }
}
