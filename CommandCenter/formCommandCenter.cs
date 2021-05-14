using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandCenter
{
    public partial class formCommandCenter : Form
    {
        public static Form formMaster;
        public static Form formWeapon;
        public static Form formJob;
        public static Form formBounty;

        public formCommandCenter()
        {
            InitializeComponent();
            pictureBoxBounty.Image = Properties.Resources.bountyPicture;
            pictureBoxWeapon.Image = Properties.Resources.weaponPicture;
            pictureBoxJob.Image = Properties.Resources.jobsPicture;
            formMaster = this;
            formWeapon = new formWeaponGenerator();
            formJob = new formJobGenerator();
            formBounty = new formBountyGenerator();
        }

        // completely quit the program
        private void formCommandCenter_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        // play the hidden song
        private void labelSecret_Click(object sender, EventArgs e)
        {
            Console.Beep(440, 500);
            Console.Beep(440, 500);
            Console.Beep(440, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Beep(440, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Beep(440, 1000);
            Console.Beep(659, 500);
            Console.Beep(659, 500);
            Console.Beep(659, 500);
            Console.Beep(698, 350);
            Console.Beep(523, 150);
            Console.Beep(415, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Beep(440, 1000);
        }

        // close the main window and launch the weapon generator form
        private void buttonWeapon_Click(object sender, EventArgs e)
        {
            this.Hide();
            formWeapon.Show();
        }

        // close the main window and launch the job generator form
        private void buttonJob_Click(object sender, EventArgs e)
        {
            this.Hide();
            formJob.Show();
        }

        // close the main window and launch the bounty generator form
        private void buttonBounty_Click(object sender, EventArgs e)
        {
            this.Hide();
            formBounty.Show();
        }
    }
}
