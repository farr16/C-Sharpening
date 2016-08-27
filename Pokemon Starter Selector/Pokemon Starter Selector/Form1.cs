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
        String[] starterList;

        public Form1()
        {
            InitializeComponent();
            starterList = new String[7];
            starterList[0] = "Charmander:Squirtle:Bulbasaur";
            starterList[1] = "Cyndaquil:Totodile:Chikorita";
            starterList[2] = "Torchic:Mudkip:Treecko";
            starterList[3] = "Chimchar:Piplup:Turtwig";
            starterList[4] = "Tepig:Oshawott:Snivy";
            starterList[5] = "Fennekin:Froakie:Chespin";
            starterList[6] = "Litten:Popplio:Rowlet";
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
            int index = listBox1.SelectedIndex;
            if (index < 7)
                label1.Text = starterList[listBox1.SelectedIndex];
            else
            {
                label1.Text = "Custom";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            bool b = index < 7;
            set_TextBoxes(b, index);
            set_Labels(b);
        }

        private void set_TextBoxes(bool b, int i)
        {
            textBox1.ReadOnly = b;
            textBox2.ReadOnly = b;
            textBox3.ReadOnly = b;
        }

        private void set_Labels(bool b)
        {
            if (b)
            {
                label2.Text = "Fire Type:";
                label3.Text = "Water Type:";
                label4.Text = "Grass Type:";
            }
            else
            {
                label2.Text = "Enter Pokemon 1:";
                label3.Text = "Enter Pokemon 2:";
                label4.Text = "Enter Pokemon 3:";
            }
        }
    }
}
