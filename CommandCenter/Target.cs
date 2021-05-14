using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandCenter
{
    class Target
    {
        public string name { get; set; }
        public string race { get; }
        public string gender { get; }
        public int age { get; }
        public string crime { get; }

        // create an instance of a target for Bounty class
        public Target(int r)
        {
            name = null;
            race = Shuffler.getRandomElement("races");
            gender = getRandomGender();
            age = getRandomAge();
            crime = getRandomCrime(r);
        }

        // determine the target's gender randomly
        private string getRandomGender()
        {
            int n = new Random(Guid.NewGuid().GetHashCode()).Next(1, 1001);
            if (n <= 480)
            {
                return "Male";
            }
            else if (481 <= n && n <= 961)
            {
                return "Female";
            }
            else
            {
                return "Unknown";
            }
        }

        // detrmine the target's age randomly
        private int getRandomAge()
        {
            return new Random(Guid.NewGuid().GetHashCode()).Next(18, 81);
        }

        // use the risk level determined by the Bounty Generator Form 
        // to return a random element from the corresponding file
        private string getRandomCrime(int RiskLevel)
        {
            if (RiskLevel == 3)
            {
                return Shuffler.getRandomElement("highRiskCrimes");
            }
            else if (RiskLevel == 2)
            {
                return Shuffler.getRandomElement("moderateRiskCrimes");
            }
            else
            {
                return Shuffler.getRandomElement("lowRiskCrimes");
            }
        }
    }
}
