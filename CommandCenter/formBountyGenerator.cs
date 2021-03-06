using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandCenter
{
    public partial class formBountyGenerator : Form
    {
        public int globalCounter;
        public static int riskLevel = 1;
        public static bool specialConditions = false;
        public static int numberOfTargets = 1;
        public static int partyMembers = 1;
        private readonly Random seed = new Random(Guid.NewGuid().GetHashCode()); 
        Bounty generatedBounty;

        public formBountyGenerator()
        {
            InitializeComponent();
            pictureBoxBounty.Image = Properties.Resources.bountyPicture;

            globalCounter = 0;
            riskLow.Checked = true;
            riskModerate.Checked = false;
            riskHigh.Checked = false;
            conditionsTrue.Checked = false;
            conditionsFalse.Checked = true;
            targetCounter.Value = 1;
            partyCounter.Value = 1;
            textBoxReadout.Text = null;
        }

        private void formBountyGenerator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            formCommandCenter.formMaster.Show();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            globalCounter += 1;
            generatedBounty = new Bounty(globalCounter, riskLevel, numberOfTargets, partyMembers, specialConditions);
            textBoxReadout.Text = generatedBounty.ToString();
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            globalCounter += 1;
            double coinFlip = seed.NextDouble();
            bool outcome;
            if(coinFlip >= 0.50)
            {
                outcome = true;
            }
            else
            {
                outcome = false;
            }

            generatedBounty = new Bounty(globalCounter, seed.Next(1, 4), seed.Next(1, 7), partyMembers, outcome);
            textBoxReadout.Text = generatedBounty.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (generatedBounty != null)
            {
                textBoxReadout.Text = "";
                object[] rowToAdd = { generatedBounty.ID, generatedBounty.location, generatedBounty.riskLevel, generatedBounty.numberOfTargets,
                generatedBounty.reward.ToString("N0") + " cR", generatedBounty };

                tablePreviousBounties.Rows.Insert(0, rowToAdd);
                tablePreviousBounties.AutoResizeColumns();
                tablePreviousBounties.Rows[0].Selected = true;
                Bounty selected = (Bounty) tablePreviousBounties[5, 0].Value;
                textBoxPreviousBounty.Text = selected.ToString();
                label1.Text = "Details of Bounty " + selected.ID + ":";
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int updater = 0;
            // removes a single selected row from the table
            foreach (DataGridViewRow row in tablePreviousBounties.SelectedRows)
            {
                updater = row.Index;
                tablePreviousBounties.Rows.RemoveAt(row.Index);
            }
            //update the textboxes as if a new weapon was chosen (because the weapon after the deleted weapon IS chosen by default)
            try
            {
                tablePreviousBounties_CellClick(this.tablePreviousBounties, new DataGridViewCellEventArgs(0, updater));
            }
            catch
            {
                tablePreviousBounties_CellClick(this.tablePreviousBounties, new DataGridViewCellEventArgs(0, updater - 1));
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            globalCounter = 0;
            riskLow.Checked = true;
            riskModerate.Checked = false;
            riskHigh.Checked = false;
            conditionsTrue.Checked = false;
            conditionsFalse.Checked = true;
            targetCounter.Value = 1;
            partyCounter.Value = 1;
            textBoxReadout.Text = null;
            textBoxPreviousBounty.Text = "";
            tablePreviousBounties.Rows.Clear();
            label1.Text = "Readout of Selected Entry: ";
        }

        private void conditionsTrue_CheckedChanged(object sender, EventArgs e)
        {
            specialConditions = true;
        }

        private void conditionsFalse_CheckedChanged(object sender, EventArgs e)
        {
            specialConditions = false;
        }

        private void targetCounter_ValueChanged(object sender, EventArgs e)
        {
            numberOfTargets = (int) targetCounter.Value;
        }

        private void partyCounter_ValueChanged(object sender, EventArgs e)
        {
            partyMembers = (int) partyCounter.Value;
        }

        private void riskLow_CheckedChanged(object sender, EventArgs e)
        {
            riskLevel = 1;

        }

        private void riskModerate_CheckedChanged(object sender, EventArgs e)
        {
            riskLevel = 2;

        }

        private void riskHigh_CheckedChanged(object sender, EventArgs e)
        {
            riskLevel = 3;
        }

        private void tablePreviousBounties_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.tablePreviousBounties.Rows[e.RowIndex];

                Bounty comparator = (Bounty) row.Cells[5].Value;
                textBoxPreviousBounty.Text = comparator.ToString();
                label1.Text = "Details of Bounty " + comparator.ID + ":";
            }
        }
    }
}