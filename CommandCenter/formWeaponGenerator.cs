using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandCenter
{
    public partial class formWeaponGenerator : Form
    {
        private static Dictionary<string, Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>> catalog =
               new Dictionary<string, Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>>();
        int rarityLevel;
        int quantity;
        Weapon generatedWeapon;
        public static RichTextBox tbConsole;
        Random seed = new Random(Guid.NewGuid().GetHashCode());

        public formWeaponGenerator()
        {
            InitializeComponent();
            pictureBoxWeapon.Image = Properties.Resources.weaponPicture;
            tbConsole = textBoxConsole;

            initializeWeaponsDictionary();

            batchQuantity.Value = 1;
            rarityLevel = 5;
            buttonFullRandom.Checked = true;
            buttonCommon.Checked = false;
            buttonUncommon.Checked = false;
            buttonRare.Checked = false;
            buttonExotic.Checked = false;

            comboBoxWeaponTypes.SelectedIndex = 0;

            tbConsole.Text = "";
            textBoxAccuracy.Text = "-";
            textBoxAPCost.Text = "-";
            textBoxCapacity.Text = "-";
            textBoxClassification.Text = "-";
            textBoxCritPower.Text = "-";
            textBoxCritRange.Text = "-";
            textBoxDamage.Text = "-";
            textBoxDurability.Text = "-";
            textBoxManufacturer.Text = "-";
            textBoxMSRP.Text = "-";
            textBoxProperties.Text = "-";
            textBoxRange.Text = "-";
            textBoxRarity.Text = "-";
            textBoxRateOfFire.Text = "-";
            textBoxWeaponType.Text = "-";
        }
        private void formWeaponGenerator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            formCommandCenter.formMaster.Show();
        }

        // generates a dictionary of weapons from the Player's Handbook and adds them to a catalog
        // all key values are added to the list of options for the comboBox to select from
        private void initializeWeaponsDictionary()
        {
            // placeholder value for display in comboBox only
            catalog.Add("Any", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                (null, null, null, null, new double[] { 0, 0, 0 }, new double[] { 0, 0, 0 }, null, new double[] { 0, 0, 0 }, null, new double[] { 0, 0, 0 }, new double[] { 0, 0, 0, 0, 0 }, 0));

            // base weapon values alphabetized for use in combobox
            catalog.Add("Blaster Carbine", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Loading, Stun, Light", "1 of 3d8", "20", new double[] { 1.5, 2, 3 }, new double[] { 50, 60, 70 }, "S/A5", new double[] { 7, 6, 5 }, "100", new double[] { 2, 3, 5, 6, 7 }, new double[] { -2, -1, 0, 1, 2 }, 850));

            catalog.Add("Blaster Pistol", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Loading, Stun, Light", "1 of 3d6", "20", new double[] { 1.5, 2, 3 }, new double[] { 25, 35, 45 }, "S", new double[] { 5, 4, 3 }, "80", new double[] { 2, 3, 5, 6, 7 }, new double[] { -2, -1, 0, 1, 2 }, 400));

            catalog.Add("Blaster Repeater", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Loading, Mounted, Restricted, Heavy", "5d10", "20", new double[] { 1.5, 2, 3 }, new double[] { 80, 100, 120 }, "A10", new double[] { 13, 12, 11 }, "150", new double[] { 1, 2, 4, 5, 6 }, new double[] { -2, -1, 0, 1, 2 }, 3000));

            catalog.Add("Blaster Rifle", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Loading, Medium", "1 of 3d10", "20", new double[] { 1.5, 2, 3 }, new double[] { 60, 80, 100 }, "S/A5", new double[] { 9, 8, 7 }, "50", new double[] { 2, 3, 4, 5, 6 }, new double[] { -2, -1, 0, 1, 2 }, 900));

            catalog.Add("Compact Slugthrower Pistol", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Loading, Light", "1 of 3d4", "18-20", new double[] { 1.5, 2, 3 }, new double[] { 20, 30, 40 }, "S", new double[] { 4, 3, 2 }, "10", new double[] { 2, 3, 4, 5, 6 }, new double[] { -2, -1, 0, 1, 2 }, 150));

            catalog.Add("Compound Bow", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Two-Handed, Medium", "1d10", "20", new double[] { 1.5, 2, 3 }, new double[] { 140, 150, 160 }, "S", new double[] { 8, 7, 6 }, "1", new double[] { 2, 3, 5, 6, 7 }, new double[] { -2, -1, 0, 1, 2 }, 150));

            catalog.Add("Cycler Rifle", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Loading, Heavy", "1 of 3d10", "20", new double[] { 2.5, 3, 3.5 }, new double[] { 100, 120, 140 }, "S", new double[] { 11, 10, 9 }, "5", new double[] { 1, 2, 3, 4, 5 }, new double[] { -2, -1, 0, 1, 2 }, 300));

            catalog.Add("Disruptor Rifle", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Loading, Illegal, Medium", "1 of 3d10", "19-20", new double[] { 2.5, 3, 3.5 }, new double[] { 160, 180, 200 }, "S", new double[] { 9, 8, 7 }, "1", new double[] { 2, 3, 5, 6, 7 }, new double[] { -2, -1, 0, 1, 2 }, 5000));

            catalog.Add("Electro-whip", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Melee", "Ensnaring, Finesse, Reach", "1 of 2d4", "19-20", new double[] { 1.5, 2, 3 }, new double[] { 10, 10, 10 }, "N/A", new double[] { 7, 6, 5 }, "N/A", new double[] {2, 3, 5, 6, 7 }, new double[] { 0, 0, 0, 0, 0 }, 1200));

            catalog.Add("Electrostaff", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Melee", "Special, Two-Handed, Double Weapon", "1 of 3d12", "18-20", new double[] { 1.5, 2, 3 }, new double[] { 5, 5, 5 }, "N/A", new double[] { 13, 12, 11 }, "N/A", new double[] { 2, 3, 4, 5, 6 }, new double[] { 0, 0, 0, 0, 0 }, 4500));

            catalog.Add("Energy Bow", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Two-Handed, Medium", "1 of 2d10", "20", new double[] { 1.5, 2, 3 }, new double[] { 140, 150, 160 }, "S", new double[] { 8, 7, 6 }, "1", new double[] { 2, 3, 5, 6, 7 }, new double[] { -2, -1, 0, 1, 2 }, 1200));

            catalog.Add("Flamethrower", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Loading, Illegal, Incendiary, Heavy", "1 of 2d6 (E)", "19-20", new double[] { 1.5, 2, 3 }, new double[] { 20, 30, 40 }, "S/A", new double[] { 13, 12, 11 }, "100 (S1/A5)", new double[] { 2, 3, 4, 5, 6 }, new double[] { -2, -1, 0, 1, 2 }, 1000));

            catalog.Add("Grenade Launcher", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Loading, Restricted, Medium", "-", "19-20", new double[] { 1.5, 2, 3 }, new double[] { 60, 80, 100 }, "S", new double[] { 9, 8, 7 }, "6 (S1)", new double[] { 1, 2, 4, 5, 6 }, new double[] { -2, -1, 0, 1, 2 }, 1200));

            catalog.Add("Heavy Blaster Pistol", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Loading, Light", "1 of 3d8", "20", new double[] { 1.5, 2, 3 }, new double[] { 30, 40, 50 }, "S", new double[] { 6, 5, 4 }, "60", new double[] { 2, 3, 5, 6, 7 }, new double[] { -2, -1, 0, 1, 2 }, 700));

            catalog.Add("Heavy Blaster Rifle", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Loading, Heavy", "2 of 4d10", "20", new double[] { 1.5, 2, 3 }, new double[] { 80, 100, 120 }, "S/A10", new double[] { 11, 10, 9 }, "100", new double[] { 1, 2, 4, 5, 6 }, new double[] { -2, -1, 0, 1, 2 }, 1500));

            catalog.Add("Heavy Marksman Slugrifle", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Loading, Mounted, Heavy", "2 of 4d10", "19-20", new double[] { 2.5, 3, 3.5 }, new double[] { 160, 180, 200 }, "S", new double[] { 13, 12, 11 }, "5", new double[] { 1, 2, 3, 4, 5 }, new double[] { -2, -1, 0, 1, 2 }, 3000));

            catalog.Add("Ion Blaster", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Loading, Ion, Light", "1 of 3d8", "19-20", new double[] { 1.5, 2, 3 }, new double[] { 10, 20, 30 }, "S", new double[] { 7, 6, 5 }, "10", new double[] { 2, 3, 5, 6, 7 }, new double[] { -2, -1, 0, 1, 2 }, 250));

            catalog.Add("Light Blaster Pistol", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Loading, Light", "1 of 2d6", "19-20", new double[] { 1.5, 2, 3 }, new double[] { 20, 30, 40 }, "S", new double[] { 4, 3, 2 }, "100", new double[] { 2, 3, 5, 6, 7 }, new double[] { -2, -1, 0, 1, 2 }, 200));

            catalog.Add("Marksman Blaster Carbine", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Loading, Medium", "1 of 3d12", "20", new double[] { 1.5, 2, 3 }, new double[] { 100, 120, 140 }, "S", new double[] { 7, 6, 5 }, "30", new double[] { 2, 3, 5, 6, 7 }, new double[] { -2, -1, 0, 1, 2 }, 1150));

            catalog.Add("Marksman Blaster Rifle", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Loading, Heavy", "1 of 4d12", "19-20", new double[] { 1.5, 2, 3 }, new double[] { 160, 180, 200 }, "S", new double[] { 11, 10, 9 }, "20", new double[] { 2, 3, 4, 5, 6 }, new double[] { -2, -1, 0, 1, 2 }, 1275));

            catalog.Add("Marksman Slugthrower Carbine", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Loading, Medium", "1 of 3d10", "19-20", new double[] { 1.5, 2, 3 }, new double[] { 100, 120, 140 }, "S", new double[] { 7, 6, 5 }, "20", new double[] { 2, 3, 4, 5, 6 }, new double[] { -2, -1, 0, 1, 2 }, 400));

            catalog.Add("Rocket Launcher", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Loading, Restricted, Heavy", "-", "19-20", new double[] { 1.5, 2, 3 }, new double[] { 80, 100, 120 }, "S", new double[] { 13, 12, 11 }, "1 (S1)", new double[] { 1, 2, 4, 5, 6 }, new double[] { -2, -1, 0, 1, 2 }, 2000));

            catalog.Add("Scatter Gun", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Loading, Medium", "2d6 / 2d10", "18-20", new double[] { 1.5, 2, 3 }, new double[] { 10, 20, 30 }, "S", new double[] { 9, 8, 7 }, "10", new double[] { 1, 2, 3, 4, 5 }, new double[] { -2, -1, 0, 1, 2 }, 200));

            catalog.Add("Shockgloves", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Melee", "Finesse, Unarmed, Stun", "1 of 2d6", "19-20", new double[] { 1.5, 2, 3 }, new double[] { 5, 5, 5 }, "N/A", new double[] { 5, 4, 3 }, "N/A", new double[] { 2, 3, 5, 6, 7 }, new double[] { 0, 0, 0, 0, 0 }, 500));

            catalog.Add("Slugthrower Carbine", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Loading, Light", "1 of 3d6", "19-20", new double[] { 1.5, 2, 3 }, new double[] { 50, 60, 70 }, "S/A5", new double[] { 7, 6, 5 }, "30", new double[] { 2, 3, 4, 5, 6 }, new double[] { -2, -1, 0, 1, 2 }, 215));

            catalog.Add("Slugthrower Heavy Rifle", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Loading, Heavy", "2 of 4d8", "20", new double[] { 1.5, 2, 3 }, new double[] { 80, 100, 120 }, "S/A10", new double[] { 11, 10, 9 }, "100", new double[] { 1, 2, 3, 4, 5 }, new double[] { -2, -1, 0, 1, 2 }, 375));

            catalog.Add("Slugthrower Hunting Rifle", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Loading, Medium", "1 of 3d8", "18-20", new double[] { 1.5, 2, 3 }, new double[] { 100, 120, 140 }, "S", new double[] { 9, 8, 7 }, "5", new double[] { 1, 2, 4, 5, 6 }, new double[] { -2, -1, 0, 1, 2 }, 125));

            catalog.Add("Slugthrower Marksman Rifle", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Loading, Heavy", "1 of 4d10", "18-20", new double[] { 1.5, 2, 3 }, new double[] { 160, 180, 200 }, "S", new double[] { 11, 10, 9 }, "10", new double[] { 2, 3, 5, 6, 7 }, new double[] { -2, -1, 0, 1, 2 }, 520));

            catalog.Add("Slugthrower Pistol", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Loading, Light", "1 of 4d4", "19-20", new double[] { 1.5, 2, 3 }, new double[] { 25, 35, 45 }, "S", new double[] { 5, 4, 3 }, "20", new double[] { 2, 3, 5, 6, 7 }, new double[] { -2, -1, 0, 1, 2 }, 100));

            catalog.Add("Slugthrower Repeater", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Loading, Mounted, Restricted, Heavy", "5d8", "19-20", new double[] { 1.5, 2, 3 }, new double[] { 80, 100, 120 }, "A10", new double[] { 13, 12, 11 }, "200", new double[] { 1, 2, 3, 4, 5 }, new double[] { -2, -1, 0, 1, 2 }, 750));

            catalog.Add("Slugthrower Revolver", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Loading, Light", "1 of 3d6", "19-20", new double[] { 1.5, 2, 3 }, new double[] { 30, 40, 50 }, "S", new double[] { 6, 5, 4 }, "20", new double[] { 2, 3, 4, 5, 6 }, new double[] { -2, -1, 0, 1, 2 }, 175));

            catalog.Add("Slugthrower Rifle", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Loading, Medium", "1 of 3d8", "19-20", new double[] { 1.5, 2, 3 }, new double[] { 60, 80, 100 }, "S/A5", new double[] { 9, 8, 7 }, "50", new double[] { 1, 2, 4, 5, 6 }, new double[] { -2, -1, 0, 1, 2 }, 225));

            catalog.Add("Sporting Rifle", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Loading, Medium", "1 of 3d10", "20", new double[] { 2.5, 3, 3.5 }, new double[] { 130, 150, 170 }, "S", new double[] { 9, 8, 7 }, "25", new double[] { 2, 3, 5, 6, 7 }, new double[] { -2, -1, 0, 1, 2 }, 1000));

            catalog.Add("Stun Baton", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Melee", "Finesse, Stun, Light", "1 of 2d8", "18-20", new double[] { 1.5, 2, 3 }, new double[] { 5, 5, 5 }, "N/A", new double[] { 6, 5, 4 }, "N/A", new double[] { 1, 2, 4, 5, 6 }, new double[] { 0, 0, 0, 0, 0 }, 600));

            catalog.Add("Vibro-axe", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Melee", "Two-Handed", "1 of 2d10", "18-20", new double[] { 1.5, 2, 3 }, new double[] { 5, 5, 5 }, "N/A", new double[] { 11, 10, 9 }, "N/A", new double[] { 2, 3, 4, 5, 6 }, new double[] { 0, 0, 0, 0, 0 }, 525));

            catalog.Add("Vibroblade", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Melee", "Finesse, Light", "1 of 2d6", "18-20", new double[] { 1.5, 2, 3 }, new double[] { 5, 5, 5 }, "N/A", new double[] { 7, 6, 5 }, "N/A", new double[] { 2, 3, 4, 5, 6 }, new double[] { 0, 0, 0, 0, 0 }, 250));

            catalog.Add("Vibrodagger", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Melee", "Finesse, Thrown (20/60), Light", "1 of 2d4", "18-20", new double[] { 1.5, 2, 3 }, new double[] { 5, 5, 5 }, "N/A", new double[] { 6, 5, 4 }, "N/A", new double[] { 1, 2, 4, 5, 6 }, new double[] { 0, 0, 0, 0, 0 }, 160));

            catalog.Add("Vibropike", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Melee", "Reach, Two-Handed", "1 of 2d12", "18-20", new double[] { 1.5, 2, 3 }, new double[] { 10, 10, 10 }, "N/A", new double[] { 13, 12, 11 }, "N/A", new double[] { 2, 3, 4, 5, 6 }, new double[] { 0, 0, 0, 0, 0 }, 625));

            catalog.Add("Vibrosword", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Melee", "Versatile", "1 of 2d8 / 1 of 2d10", "18-20", new double[] { 1.5, 2, 3 }, new double[] { 5, 5, 5 }, "N/A", new double[] { 9, 8, 7 }, "N/A", new double[] { 2, 3, 4, 5, 6 }, new double[] { 0, 0, 0, 0, 0 }, 450));

            catalog.Add("Wrist-mounted Flamethrower", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Loading, Illegal, Incendiary", "1 of 2d4 (E)", "19-20", new double[] { 1.5, 2, 3 }, new double[] { 10, 20, 30 }, "S/A", new double[] { 6, 5, 4 }, "10 (S1/A5)", new double[] { 1, 2, 3, 4, 5 }, new double[] { -2, -1, 0, 1, 2 }, 4000));

            catalog.Add("Wrist Rockets", new Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>
                ("Ranged", "Ammunition, Loading, Illegal", "-", "18-20", new double[] { 1.5, 2, 3 }, new double[] { 40, 60, 80 }, "S/A", new double[] { 7, 6, 5 }, "3 (S1/A3)", new double[] { 1, 2, 3, 4, 5 }, new double[] { -2, -1, 0, 1, 2 }, 3500));

            comboBoxWeaponTypes.DataSource = new BindingSource(catalog, null);
            comboBoxWeaponTypes.DisplayMember = "Key";
            comboBoxWeaponTypes.ValueMember = "Value";
        }

        // create an instance of a weapon using the Weapon Generator Form
        // form fields for the parameters
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            string dictionaryKey = comboBoxWeaponTypes.Text;
            Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int> dictionaryValue = catalog[dictionaryKey];

            int rand = seed.Next(0, catalog.Count);

            KeyValuePair<string, Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>> selected =
                new KeyValuePair<string, Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>>(dictionaryKey, dictionaryValue);

            if (quantity > 1)
            {
                // create as many weapons as specified by batch quantity
                for (int instances = 0; instances < quantity; instances++)
                {
                    // ensures a weapon of the specified type will be
                    // selected if the "Any" option is not chosen
                    if (dictionaryKey != "Any")
                    {
                        generatedWeapon = new Weapon(selected, rarityLevel);
                    }
                    // handles the selection of the "Any" option
                    else
                    {
                        KeyValuePair<string, Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>> temp = catalog.ElementAt(rand);

                        while (temp.Key == "Any")
                        {
                            rand = seed.Next(0, catalog.Count);
                            temp = catalog.ElementAt(rand);
                        }

                        selected = temp;
                        generatedWeapon = new Weapon(selected, rarityLevel);
                    }

                    // change the weapon's 5 randomizable stats according to its target rarity
                    if (generatedWeapon.rarity == "Common")
                    {
                        Weapon.makeCommon(generatedWeapon);
                    }
                    else if (generatedWeapon.rarity == "Uncommon")
                    {
                        Weapon.makeUncommon(generatedWeapon);
                    }
                    else if (generatedWeapon.rarity == "Rare")
                    {
                        Weapon.makeRare(generatedWeapon);
                    }
                    else if (generatedWeapon.rarity == "Exotic")
                    {
                        Weapon.makeExotic(generatedWeapon);
                    }

                    // move the caret to the end of the text
                    textBoxConsole.SelectionStart = textBoxConsole.TextLength;
                    // scroll to the caret so the user can see the weapon they just created
                    textBoxConsole.ScrollToCaret();

                    // add the newly created weapon to the table, sorted by column, then highlight it
                    object[] rowToAdd = { generatedWeapon.weaponType, generatedWeapon.manufacturer, generatedWeapon.properties,
                    generatedWeapon.rarity, generatedWeapon.damage, generatedWeapon.critRange, generatedWeapon.critPower.ToString("N1") + "x",
                    generatedWeapon.range.ToString(), generatedWeapon.ROF, generatedWeapon.APCost.ToString(), generatedWeapon.CAP,
                    generatedWeapon.DUR.ToString(), generatedWeapon.accuracy.ToString("+0;-#"), generatedWeapon.MSRP.ToString("N0") + " cR", generatedWeapon.classification, generatedWeapon };

                    tablePreviousWeapons.Visible = true;
                    tablePreviousWeapons.Rows.Insert(0, rowToAdd);
                    tablePreviousWeapons.AutoResizeColumns();
                    tablePreviousWeapons.Rows[0].Selected = true;
                    rand = seed.Next(0, catalog.Count);
                }

                batchQuantity.Value = 1;
            }
            // create only a single instance of a random weapon, with the choice to add to table still reliant on user input
            else if (quantity <= 1)
            {
                // ensures a weapon of the specified type will be
                // selected if the "Any" option is not chosen
                if (dictionaryKey != "Any")
                {
                    generatedWeapon = new Weapon(selected, rarityLevel);
                }

                // handles the selection of the "Any" option
                else
                {
                    KeyValuePair<string, Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>> temp = catalog.ElementAt(rand);

                    while (temp.Key == "Any")
                    {
                        rand = seed.Next(0, catalog.Count);
                        temp = catalog.ElementAt(rand);
                    }

                    selected = temp;
                    generatedWeapon = new Weapon(selected, rarityLevel);
                }

                // change the weapon's 5 randomizable stats according to its target rarity
                if (generatedWeapon.rarity == "Common")
                {
                    Weapon.makeCommon(generatedWeapon);
                }
                else if (generatedWeapon.rarity == "Uncommon")
                {
                    Weapon.makeUncommon(generatedWeapon);
                }
                else if (generatedWeapon.rarity == "Rare")
                {
                    Weapon.makeRare(generatedWeapon);
                }
                else if (generatedWeapon.rarity == "Exotic")
                {
                    Weapon.makeExotic(generatedWeapon);
                }
            }

            // update the textbox to hold the data of the last generated instance of a weapon
            textBoxAccuracy.Text = generatedWeapon.accuracy.ToString("+0;-#");
            textBoxAPCost.Text = generatedWeapon.APCost.ToString();
            textBoxCapacity.Text = generatedWeapon.CAP.ToString();
            textBoxClassification.Text = generatedWeapon.classification.ToString();
            textBoxCritPower.Text = generatedWeapon.critPower.ToString("N1") + "x";
            textBoxCritRange.Text = generatedWeapon.critRange.ToString();
            textBoxDamage.Text = generatedWeapon.damage.ToString();
            textBoxDurability.Text = generatedWeapon.DUR.ToString();
            textBoxMSRP.Text = generatedWeapon.MSRP.ToString("N0") + " cR";
            textBoxProperties.Text = generatedWeapon.properties.ToString();
            textBoxRange.Text = generatedWeapon.range.ToString();
            textBoxRateOfFire.Text = generatedWeapon.ROF.ToString();
            textBoxWeaponType.Text = generatedWeapon.weaponType.ToString();
            textBoxManufacturer.Text = generatedWeapon.manufacturer.ToString();
            textBoxRarity.Text = generatedWeapon.rarity.ToString();
            getColors(generatedWeapon);

            //move the caret to the end of the text
            textBoxConsole.SelectionStart = textBoxConsole.TextLength;
            // scroll to the caret so the user can see the weapon they just created
            textBoxConsole.ScrollToCaret();
        }

        // delete all weapon generator history and reset the form fields to their default values 
        private void buttonClearForm_Click(object sender, EventArgs e)
        {
            batchQuantity.Value = 1;
            rarityLevel = 5;
            buttonFullRandom.Checked = true;
            buttonCommon.Checked = false;
            buttonUncommon.Checked = false;
            buttonRare.Checked = false;
            buttonExotic.Checked = false;
            comboBoxWeaponTypes.SelectedIndex = 0;
            tablePreviousWeapons.Visible = false;
            tablePreviousWeapons.Rows.Clear();

            tbConsole.Text = "";
            textBoxAccuracy.Text = "-";
            textBoxAccuracy.BackColor = Color.White;
            textBoxAPCost.Text = "-";
            textBoxAPCost.BackColor = Color.White;
            textBoxCapacity.Text = "-";
            textBoxClassification.Text = "-";
            textBoxCritPower.Text = "-";
            textBoxCritPower.BackColor = Color.White;
            textBoxCritRange.Text = "-";
            textBoxDamage.Text = "-";
            textBoxDurability.Text = "-";
            textBoxDurability.BackColor = Color.White;
            textBoxManufacturer.Text = "-";
            textBoxMSRP.Text = "-";
            textBoxProperties.Text = "-";
            textBoxRange.Text = "-";
            textBoxRange.BackColor = Color.White;
            textBoxRarity.Text = "-";
            textBoxRarity.BackColor = Color.White;
            textBoxRateOfFire.Text = "-";
            textBoxWeaponType.Text = "-";
        }

        private void buttonAddToList_Click(object sender, EventArgs e)
        {
            tablePreviousWeapons.Visible = true;

            // add the newly created weapon to the table, sorted by column
            if (generatedWeapon != null)
            {
                object[] rowToAdd = { generatedWeapon.weaponType, generatedWeapon.manufacturer, generatedWeapon.properties,
                generatedWeapon.rarity, generatedWeapon.damage, generatedWeapon.critRange, generatedWeapon.critPower.ToString("N1") +"x",
                generatedWeapon.range.ToString(), generatedWeapon.ROF, generatedWeapon.APCost.ToString(), generatedWeapon.CAP,
                generatedWeapon.DUR.ToString(), generatedWeapon.accuracy.ToString("+0;-#"), generatedWeapon.MSRP.ToString("N0") + " cR", generatedWeapon.classification, generatedWeapon };

                tablePreviousWeapons.Rows.Insert(0, rowToAdd);
                tablePreviousWeapons.AutoResizeColumns();
                tablePreviousWeapons.Rows[0].Selected = true;
            }
            batchQuantity.Value = 1;
        }

        private void buttonRemoveFromList_Click(object sender, EventArgs e)
        {
            int updater = 0;
            // removes a single selected row from the table
            foreach (DataGridViewRow row in tablePreviousWeapons.SelectedRows)
            {
                updater = row.Index;
                tablePreviousWeapons.Rows.RemoveAt(row.Index);
            }
            //update the textboxes as if a new weapon was chosen (because the weapon after the deleted weapon IS chosen by default)
            try
            {
                tablePreviousWeapons_CellClick(this.tablePreviousWeapons, new DataGridViewCellEventArgs(0, updater));

            }
            catch
            {
                tablePreviousWeapons_CellClick(this.tablePreviousWeapons, new DataGridViewCellEventArgs(0, updater - 1));
            }
            batchQuantity.Value = 1;
        }

        private void buttonFullRandom_CheckedChanged(object sender, EventArgs e)
        {
            rarityLevel = 5;
        }

        private void buttonCommon_CheckedChanged(object sender, EventArgs e)
        {
            rarityLevel = 4;
        }

        private void buttonUncommon_CheckedChanged(object sender, EventArgs e)
        {
            rarityLevel = 3;
        }

        private void buttonRare_CheckedChanged(object sender, EventArgs e)
        {
            rarityLevel = 2;
        }

        private void buttonExotic_CheckedChanged(object sender, EventArgs e)
        {
            rarityLevel = 1;
        }

        private void batchQuantity_ValueChanged(object sender, EventArgs e)
        {
            quantity = (int) batchQuantity.Value;
        }

        private void tablePreviousWeapons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.tablePreviousWeapons.Rows[e.RowIndex];

                textBoxWeaponType.Text = row.Cells[0].Value.ToString();
                textBoxManufacturer.Text = row.Cells[1].Value.ToString();
                textBoxProperties.Text = row.Cells[2].Value.ToString();
                textBoxRarity.Text = row.Cells[3].Value.ToString();
                textBoxDamage.Text = row.Cells[4].Value.ToString();
                textBoxCritRange.Text = row.Cells[5].Value.ToString();
                textBoxCritPower.Text = row.Cells[6].Value.ToString();
                textBoxRange.Text = row.Cells[7].Value.ToString();
                textBoxRateOfFire.Text = row.Cells[8].Value.ToString();
                textBoxAPCost.Text = row.Cells[9].Value.ToString();
                textBoxCapacity.Text = row.Cells[10].Value.ToString();
                textBoxDurability.Text = row.Cells[11].Value.ToString();
                textBoxAccuracy.Text = row.Cells[12].Value.ToString();
                textBoxMSRP.Text = row.Cells[13].Value.ToString();
                textBoxClassification.Text = row.Cells[14].Value.ToString();
                Weapon comparator = (Weapon) row.Cells[15].Value;
                getColors(comparator);
            }
        }

        // toggle the visibility of the console by clicking it
        private void buttonConsole_Click(object sender, EventArgs e)
        {
            if (textBoxConsole.Visible == true)
            {
                textBoxConsole.Visible = false;
            }
            else if (textBoxConsole.Visible == false)
            {
                textBoxConsole.Visible = true;
            }
        }

        // changes the textbox colors if a weapon's new stats are
        // changed from the default values of that weapon's type
        private void getColors(Weapon w)
        {
            string name = w.weaponType.Substring(w.weaponType.IndexOf(' ') + 1);

            double baseAccuracy = catalog[name].accuracy[2];
            double baseAPCost = catalog[name].APCost[1];
            double baseCritPower = catalog[name].critPower[1];
            double baseDUR = catalog[name].DUR[2];
            double baseRange = catalog[name].range[1];

            // color codes for accuracy stat changes
            if (w.accuracy > baseAccuracy)
            {
                textBoxAccuracy.BackColor = Color.FromArgb(144, 238, 144);
            }
            else if (w.accuracy < baseAccuracy)
            {
                textBoxAccuracy.BackColor = Color.FromArgb(238, 145, 145);
            }
            else if (w.accuracy == baseAccuracy)
            {
                textBoxAccuracy.BackColor = Color.White;
            }

            // color codes for AP cost stat changes
            if (w.APCost < baseAPCost)
            {
                textBoxAPCost.BackColor = Color.FromArgb(144, 238, 144);
            }
            else if (w.APCost > baseAPCost)
            {
                textBoxAPCost.BackColor = Color.FromArgb(238, 145, 145);
            }
            else if (w.APCost == baseAPCost)
            {
                textBoxAPCost.BackColor = Color.White;
            }

            // color codes for crit power stat changes
            if (w.critPower > baseCritPower)
            {
                textBoxCritPower.BackColor = Color.FromArgb(144, 238, 144);
            }
            else if (w.critPower < baseCritPower)
            {
                textBoxCritPower.BackColor = Color.FromArgb(238, 145, 145);
            }
            else if (w.critPower == baseCritPower)
            {
                textBoxCritPower.BackColor = Color.White;
            }

            // color codes for durability stat changes
            if (w.DUR > baseDUR)
            {
                textBoxDurability.BackColor = Color.FromArgb(144, 238, 144);
            }
            else if (w.DUR < baseDUR)
            {
                textBoxDurability.BackColor = Color.FromArgb(238, 145, 145);
            }
            else if (w.DUR == baseDUR)
            {
                textBoxDurability.BackColor = Color.White;
            }

            // color codes for range stat changes
            if (w.range > baseRange)
            {
                textBoxRange.BackColor = Color.FromArgb(144, 238, 144);
            }
            else if (w.range < baseRange)
            {
                textBoxRange.BackColor = Color.FromArgb(238, 145, 145);
            }
            else if (w.range == baseRange)
            {
                textBoxRange.BackColor = Color.White;
            }

            // color codes for rarity
            if (w.rarity == "Common")
            {
                textBoxRarity.BackColor = Color.FromArgb(236, 238, 145);
            }
            else if (w.rarity == "Uncommon")
            {
                textBoxRarity.BackColor = Color.FromArgb(145, 205, 238);
            }
            else if (w.rarity == "Rare")
            {
                textBoxRarity.BackColor = Color.FromArgb(190, 145, 238);
            }
            else if (w.rarity == "Exotic")
            {
                textBoxRarity.BackColor = Color.FromArgb(238, 196, 145);
            }
        }

        // play the secret sound
        private void labelDamage_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.wilhelm_scream);
            player.Play();
        }
    }
}