using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KerbalOrbitalCalculator
{
    public partial class Form1 : Form
    {
        private String[] planets;

        public Form1()
        {
            InitializeComponent();

            planets = new string[7] { "Moho", "Eve", "Kerbin", "Duna", "Dres", "Jool", "Eeloo" };

            for (int i=0; i<planets.Length;i++)
            {
                String planet = planets[i];
                origComboBox.Items.Add(planet);
                destComboBox.Items.Add(planet);
            }

            origComboBox.SelectedIndex = origComboBox.Items.IndexOf("Kerbin");
            destComboBox.SelectedIndex = destComboBox.Items.IndexOf("Duna");
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            Object orig = origComboBox.SelectedItem;
            Object dest = destComboBox.SelectedItem;

            int park = (int) parkingOrbitEntry.Value;

            phaseAngleDisplay.Text = origComboBox.GetItemText(orig) + " " + origComboBox.Items.IndexOf(orig);
            ejectionAngleDisplay.Text = destComboBox.GetItemText(dest) + " " + destComboBox.Items.IndexOf(dest);
            ejectionVelocityDisplay.Text = "" + (park-20);
        }
    }
}
