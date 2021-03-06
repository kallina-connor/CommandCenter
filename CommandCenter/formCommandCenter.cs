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
        public static Form formBounty;
        public static Form formWeapon;

        public formCommandCenter()
        {
            InitializeComponent();
            pictureBoxBounty.Image = Properties.Resources.bountyPicture;
            pictureBoxWeapon.Image = Properties.Resources.weaponPicture;
            pictureBoxJob.Image = Properties.Resources.jobsPicture;
            formMaster = this;
            formBounty = new formBountyGenerator();
            formWeapon = new formWeaponGenerator();
        }
        private void formCommandCenter_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

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

        private void buttonBounty_Click(object sender, EventArgs e)
        {
            this.Hide();
            formBounty.Show();
        }

        private void buttonWeapon_Click(object sender, EventArgs e)
        {
            this.Hide();
            formWeapon.Show();
        }
    }
}
