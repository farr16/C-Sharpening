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
        private String[] planetNames;
        private Body[] bodies;

        public Form1()
        {
            InitializeComponent();

            planetNames = new string[7] { "Moho", "Eve", "Kerbin", "Duna", "Dres", "Jool", "Eeloo" };

            for (int i=0; i<planetNames.Length;i++)
            {
                String planet = planetNames[i];
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

        private void initBodies()
        {
            bodies = new Body[8];
        }
    }

    public class Body
    {
        public String name;
        public float gravParam;
        public float semiMajAxis;
        public int radius;
        public float soi;

        public Body(String _name, float _gravParam, float _semiMajAxis, int _radius, float _soi)
        {
            name = _name;
            gravParam = _gravParam;
            semiMajAxis = _semiMajAxis;
            radius = _radius;
            soi = _soi;
        }
    }
}
