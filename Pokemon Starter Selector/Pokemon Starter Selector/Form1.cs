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
        Random rnd;

        public Form1()
        {
            InitializeComponent();

            // Create random object here to be used for random generation
            // so it is only created once rather than on each button press
            rnd = new Random();

            // Set up list of starters for each generation
            starterList = new string[7];
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
            // Set up each of the items in the list box
            // for selecting each Pokemon generation, or custom for entering in a custom set of starters
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
            String[] starters = new String[3];

            //get starters from the three entry boxes
            starters[0] = textBox1.Text;
            starters[1] = textBox2.Text;
            starters[2] = textBox3.Text;

            bool allFilled = true;

            for (int i=0; i<starters.Length; i++)
            {
                if (String.IsNullOrEmpty(starters[i]))
                {
                    MessageBox.Show("Enter Pokemon " + (i + 1) + " name, please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    allFilled = false;
                }
            }

            if (!allFilled)
                return;
            
            //randomly select one of the three starters
            int index = rnd.Next(0, 3);
            label1.Text = "Starter Selected: " + starters[index];

        }

        /** Code executes whenever one of the items is selected on the listbox
         * */
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            bool b = index < 7;
            set_TextBoxes(b, index);
            set_Labels(b);
        }

        /** Sets textboxes to contain starter names if generation 1-7 is selected
         * Otherwise, sets textboxes to allow input and clears them if custom input is selected
         * */
        private void set_TextBoxes(bool b, int i)
        {
            textBox1.ReadOnly = b;
            textBox2.ReadOnly = b;
            textBox3.ReadOnly = b;

            if(b)
            {
                String[] starters = starterList[i].Split(':');
                textBox1.Text = starters[0];
                textBox2.Text = starters[1];
                textBox3.Text = starters[2];
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        /** Sets labels according to whether generations 1-7 is selected or custom is selected
         * */
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
