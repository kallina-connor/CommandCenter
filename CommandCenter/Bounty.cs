using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandCenter
{
    class Bounty
    {
        public string ID;
        public string location;
        public string condition;
        public string specialConditions;
        public string riskLevel;
        public int numberOfTargets;
        public int partyMembers;
        public int reward;
        public ArrayList targetsList;
        private readonly Random seed = new Random(Guid.NewGuid().GetHashCode());

        public Bounty(int c, int r, int t, int p, bool s)
        {
            ID = makeSerial(c);
            location = Shuffler.getRandomElement("locations");
            condition = determineCondition(r);
            if (s == true)
            {
                specialConditions = Shuffler.getRandomElement("conditions");
            }
            if (r == 3)
            {
                riskLevel = "High";
            }
            else if (r == 2)
            {
                riskLevel = "Moderate";
            }
            else
            {
                riskLevel = "Low";
            }
            numberOfTargets = t;
            partyMembers = p;
            reward = calculateReward(r, numberOfTargets, partyMembers);
            targetsList = new ArrayList();
            for (int i = 1; i <= t; i++)
            {
                Target mark = new Target(r)
                {
                    name = "Target #" + i
                };
                targetsList.Add(mark);
            }
        }
    
        // determine a bounty's reward based on risk level, number of targets, and
        // number of players in the party (higher reward if party is outnumbered by targets)
        private int calculateReward(int r, int t, int p)
        {
            int conditionalMinimum;
            int conditionalMaximum;
            int bonus;

            if (r == 3)
            {
                conditionalMinimum = 2500;
                conditionalMaximum = 10000;
            }
            else if (r == 2)
            {
                conditionalMinimum = 1000;
                conditionalMaximum = 2500;
            }
            else
            {
                conditionalMinimum = 250;
                conditionalMaximum = 1000;
            }

            for (int i = t; i > 0; i--)
            {
                reward += seed.Next(conditionalMinimum, conditionalMaximum);
            }

            if (t > p)
            {
                bonus = seed.Next(50, 150);
                reward += bonus;
                return reward;
            }
            else if (t <= p)
            {
                return reward;
            }
            else
            {
                return 0;
            }
        }

        // assigns a randomized serial number to each instance of a bounty
        private string makeSerial(int c)
        {
            char[] chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string serial = "";

            for (int i = 1; i <= 3; i++)
            {
                serial += chars[seed.Next(chars.Length - 1)].ToString().ToUpperInvariant();
            }

            serial += ("-");

            for (int i = 1; i <= 2; i++)
            {
                serial += chars[seed.Next(chars.Length - 1)].ToString().ToUpperInvariant();
            }

            return c + "-" + serial + ".bty";
        }

        // assigns special conditions to each bounty based on user input
        private string determineCondition(int r)
        {
            string condition = "";
            if (r == 3)
            {
                double coinFlip = seed.NextDouble();
                if (coinFlip >= 0.50)
                {
                    condition = "may be captured dead or alive.";
                }
                else
                {
                    condition = "must be confirmed dead.";
                }
            }
            else if (r < 3)
            {
                condition = "must be brought back alive.";
            }
            return condition;
        }

        // displays details of a bounty to the user
        public override string ToString()
        {
            string readout = "";
            readout += "[BOUNTY IDENTIFICATION CODE]: " + ID + "\r\n";
            readout += "  [LOCATION]: " + location + "\r\n";
            readout += "  [RISK LEVEL]: " + riskLevel + "\r\n";
            readout += " \r\n";

            // details of each target in the bounty
            foreach (Target t in targetsList)
            {
                readout += t.name + "\r\n";
                readout += "  [RACE]: " + t.race + "\r\n";
                readout += "  [GENDER]: " + t.gender + "\r\n";
                readout += "  [APPROXIMATE AGE]: " + t.age + "\r\n";
                readout += "  [WANTED FOR]: " + t.crime + "\r\n";
                readout += " \r\n";
            }

            if (this.numberOfTargets > 1)
            {
                readout += "Targets " + condition + "\r\n";
                readout += " \r\n";
            }
            else
            {
                readout += "Target " + condition + "\r\n";
                readout += " \r\n";
            }

            if (specialConditions != null)
            {
                readout += "Bounty must also be carried out with" + specialConditions + "\r\n";
                readout += " \r\n";
            }

            readout += "[REWARD]: " + reward.ToString("N0") + " cR";
            return readout;
        }
    }
}