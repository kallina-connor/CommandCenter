using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandCenter
{
    class Weapon
    {
        // these values are inherited from weapons dictionary item's value (Tuple)
        public string classification;
        public string properties;
        public string damage;
        public string critRange;
        public double critPower { get; set; }
        public double range { get; set; }
        public string ROF;
        public double APCost { get; set; }
        public string CAP;
        public double DUR { get; set; }
        public double accuracy { get; set; }
        public int MSRP;
        public string weaponType;

        // these are created by the weapon class and then manipulated before returning to Form for textbox display
        public string manufacturer;
        public string rarity;

        public double[] allCritPowerValues { get; set; }
        public double[] allRangeValues { get; set; }
        public double[] allAPCostValues { get; set; }
        public double[] allDURValues { get; set; }
        public double[] allAccuracyValues { get; set; }

        public Dictionary<string, double> currentStats { get; set; }

        public Weapon(KeyValuePair<string, Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int>> targetWeapon, int targetRarity)
        {

            // keep all changeable weapon stats in memory for respec options to
            // avoid creating a new weapon each time a stat is modified
            allCritPowerValues = targetWeapon.Value.critPower;
            allRangeValues = targetWeapon.Value.range;
            allAPCostValues = targetWeapon.Value.APCost;
            allDURValues = targetWeapon.Value.DUR;
            allAccuracyValues = targetWeapon.Value.accuracy;

            // intialize the weapon stats to their base values as determined by the dictionary
            classification = targetWeapon.Value.classification;
            properties = targetWeapon.Value.properties;
            damage = targetWeapon.Value.damage;
            critRange = targetWeapon.Value.critRange;
            critPower = allCritPowerValues[1];      // the default choice will be the second of three index values
            range = allRangeValues[1];              // the default choice will be the second of three index values
            ROF = targetWeapon.Value.ROF;
            APCost = allAPCostValues[1];            // the default choice will be the second of three index values
            CAP = targetWeapon.Value.CAP;
            DUR = allDURValues[2];                  // the default choice will be the third of five index values
            accuracy = allAccuracyValues[2];        // the default choice will be the third of five index values
            MSRP = targetWeapon.Value.MSRP;
            weaponType = determineWeaponType(targetWeapon.Key);
            rarity = determineRarity(targetRarity);
            manufacturer = determineManufacturer();

            // create a dictionary which holds only the current values of the base states
            if (classification == "Ranged")
            {
                currentStats = new Dictionary<string, double>();
                currentStats.Add("critPower", critPower);
                currentStats.Add("range", range);
                currentStats.Add("APCost", APCost);
                currentStats.Add("DUR", DUR);
                currentStats.Add("accuracy", accuracy);
            }
            else if (classification == "Melee")
            {
                currentStats = new Dictionary<string, double>();
                currentStats.Add("critPower", critPower);
                currentStats.Add("APCost", APCost);
                currentStats.Add("DUR", DUR);
            }
        }

        // create a model number for the weapon 
        private string determineWeaponType(string t)
        {
            char[] chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] nums = "1234567890".ToCharArray();
            int targetLength = new Random(Guid.NewGuid().GetHashCode()).Next(1, 4);
            string modelNumber = null;

            for (int i = 1; i <= targetLength; i++)
            {
                modelNumber += chars[new Random(Guid.NewGuid().GetHashCode()).Next(chars.Length - 1)].ToString().ToUpperInvariant();
            }

            modelNumber += ("-");

            for (int i = 1; i <= 2; i++)
            {
                modelNumber += nums[new Random(Guid.NewGuid().GetHashCode()).Next(nums.Length - 1)];
            }

            modelNumber += chars[new Random(Guid.NewGuid().GetHashCode()).Next(chars.Length - 1)].ToString().ToLowerInvariant();


            return modelNumber + " " + t;
        }

        // roll a random number as a seed for the rarity of the weapon
        private string determineRarity(int r)
        {

            //if "any" mode is selected, reroll a chance among all four rarity types
            //Common has a 75% chance, Uncommon a 20% chance, Rare a 4% chance, and Exotic a 1% chance
            if (r >= 5)
            {
                double chance = new Random(Guid.NewGuid().GetHashCode()).NextDouble();

                if (chance <= 0.75)
                {
                    return "Common";
                }
                else if (chance <= 0.95)
                {
                    return "Uncommon";
                }
                else if (chance <= 0.99)
                {
                    return "Rare";
                }
                else if (chance <= 1.00)
                {
                    return "Exotic";
                }
                else
                {
                    return "Error: Out of Range";
                }
            }

            //if r != 5, then an explicit rarity type is chosen, and should only return that specified type
            else if (r == 4)
            {
                return "Common";
            }
            else if (r == 3)
            {
                return "Uncommon";
            }
            else if (r == 2)
            {
                return "Rare";
            }
            else if (r == 1)
            {
                return "Exotic";
            }
            else
            {
                return "Error: Out of Range";
            }
        }

        // use the Shuffler to pull from the manufacturers file
        private string determineManufacturer()
        {
            return Shuffler.getRandomElement("manufacturers");
        }

        // change a base weapon to Common
        public static void makeCommon(Weapon w)
        {
            int pos;
            int neg;
            Dictionary<string, double[]> possibleStats = new Dictionary<string, double[]>();
            List<string> options = new List<string>();

            // ranged weapons can only have these five stats changed -- keep record of all their possible values
            if (w.classification == "Ranged")
            {
                pos = 1;
                neg = 3;
                possibleStats.Add("critPower", w.allCritPowerValues);
                possibleStats.Add("range", w.allRangeValues);
                possibleStats.Add("APCost", w.allAPCostValues);
                possibleStats.Add("DUR", w.allDURValues);
                possibleStats.Add("accuracy", w.allAccuracyValues);

                options.Add("critPower");
                options.Add("range");
                options.Add("APCost");
                options.Add("DUR");
                options.Add("DUR");
                options.Add("accuracy");
                options.Add("accuracy");

                respec(w, pos, neg, w.currentStats, possibleStats, options);
            }
            // melee weapons can only have these three stats changed -- keep record of all their possible values
            else if (w.classification == "Melee")
            {
                pos = 0;
                neg = 1;
                possibleStats.Add("critPower", w.allCritPowerValues);
                possibleStats.Add("APCost", w.allAPCostValues);
                possibleStats.Add("DUR", w.allDURValues);

                options.Add("critPower");
                options.Add("APCost");
                options.Add("DUR");
                options.Add("DUR");

                respec(w, pos, neg, w.currentStats, possibleStats, options);
            }
        }

        // change a base weapon to Uncommon
        public static void makeUncommon(Weapon w)
        {
            int pos;
            int neg;
            Dictionary<string, double[]> possibleStats = new Dictionary<string, double[]>();
            List<string> options = new List<string>();

            // ranged weapons can only have these five stats changed -- keep record of all their possible values
            if (w.classification == "Ranged")
            {
                pos = 1;
                neg = 2;
                possibleStats.Add("critPower", w.allCritPowerValues);
                possibleStats.Add("range", w.allRangeValues);
                possibleStats.Add("APCost", w.allAPCostValues);
                possibleStats.Add("DUR", w.allDURValues);
                possibleStats.Add("accuracy", w.allAccuracyValues);

                options.Add("critPower");
                options.Add("range");
                options.Add("APCost");
                options.Add("DUR");
                options.Add("DUR");
                options.Add("accuracy");
                options.Add("accuracy");

                respec(w, pos, neg, w.currentStats, possibleStats, options);
            }
            // melee weapons can only have these three stats changed -- keep record of all their possible values
            else if (w.classification == "Melee")
            {
                pos = 1;
                neg = 1;
                possibleStats.Add("critPower", w.allCritPowerValues);
                possibleStats.Add("APCost", w.allAPCostValues);
                possibleStats.Add("DUR", w.allDURValues);

                options.Add("critPower");
                options.Add("APCost");
                options.Add("DUR");
                options.Add("DUR");

                respec(w, pos, neg, w.currentStats, possibleStats, options);
            }
            w.MSRP = (int) Math.Ceiling(w.MSRP * 1.25);
        }

        // change a base weapon to Rare
        public static void makeRare(Weapon w)
        {
            int pos;
            int neg;
            Dictionary<string, double[]> possibleStats = new Dictionary<string, double[]>();
            List<string> options = new List<string>();

            // ranged weapons can only have these five stats changed -- keep record of all their possible values
            if (w.classification == "Ranged")
            {
                pos = 2;
                neg = 2;
                possibleStats.Add("critPower", w.allCritPowerValues);
                possibleStats.Add("range", w.allRangeValues);
                possibleStats.Add("APCost", w.allAPCostValues);
                possibleStats.Add("DUR", w.allDURValues);
                possibleStats.Add("accuracy", w.allAccuracyValues);

                options.Add("critPower");
                options.Add("range");
                options.Add("APCost");
                options.Add("DUR");
                options.Add("DUR");
                options.Add("accuracy");
                options.Add("accuracy");

                respec(w, pos, neg, w.currentStats, possibleStats, options);
            }
            // melee weapons can only have these three stats changed -- keep record of all their possible values
            else if (w.classification == "Melee")
            {
                pos = 1;
                neg = 0;
                possibleStats.Add("critPower", w.allCritPowerValues);
                possibleStats.Add("APCost", w.allAPCostValues);
                possibleStats.Add("DUR", w.allDURValues);

                options.Add("critPower");
                options.Add("APCost");
                options.Add("DUR");
                options.Add("DUR");

                respec(w, pos, neg, w.currentStats, possibleStats, options);
            }
            w.MSRP = (int) Math.Ceiling(w.MSRP * 1.50);
        }

        // change a base weapon to Exotic
        public static void makeExotic(Weapon w)
        {
            int pos;
            int neg;
            Dictionary<string, double[]> possibleStats = new Dictionary<string, double[]>();
            List<string> options = new List<string>();

            // ranged weapons can only have these five stats changed -- keep record of all their possible values
            if (w.classification == "Ranged")
            {
                pos = 2;
                neg = 1;
                possibleStats.Add("critPower", w.allCritPowerValues);
                possibleStats.Add("range", w.allRangeValues);
                possibleStats.Add("APCost", w.allAPCostValues);
                possibleStats.Add("DUR", w.allDURValues);
                possibleStats.Add("accuracy", w.allAccuracyValues);

                options.Add("critPower");
                options.Add("range");
                options.Add("APCost");
                options.Add("DUR");
                options.Add("DUR");
                options.Add("accuracy");
                options.Add("accuracy");

                respec(w, pos, neg, w.currentStats, possibleStats, options);
            }
            // melee weapons can only have these three stats changed -- keep record of all their possible values
            else if (w.classification == "Melee")
            {
                pos = 2;
                neg = 0;
                possibleStats.Add("critPower", w.allCritPowerValues);
                possibleStats.Add("APCost", w.allAPCostValues);
                possibleStats.Add("DUR", w.allDURValues);

                options.Add("critPower");
                options.Add("APCost");
                options.Add("DUR");
                options.Add("DUR");

                respec(w, pos, neg, w.currentStats, possibleStats, options);
            }
            w.MSRP = (int) Math.Ceiling(w.MSRP * 2.00);
        }

        // use this formula to respec a weapon by specifiying the number of positive and negative changes to be made, and which stats may
        // be considerd eligible to be modified, based on classification.
        // a dicitonary of the base values must also be passed for reference during
        // comparison, to note when a change is made from the default instance of the weapon
        public static void respec(Weapon weapon, int positives, int negatives, Dictionary<string, double> currentStats, Dictionary<string, double[]> possibleStats, List<string> options)
        {
            int randomIndex;
            string targetStatName;
            double targetStatCurrentValue;
            double[] newStatValues;
            int baseStatIndex;
            List<string> previouslyChangedStats = new List<string>();    // a list of changed attributes must be kept so they can all be removed at once from the options the negatives choose
            string weaponName = weapon.rarity + " " + weapon.weaponType.ToString().Substring(weapon.weaponType.IndexOf(' ') + 1);

            // for each positive change to be made...
            for (int positiveCounter = positives; positiveCounter > 0; positiveCounter--)
            {
                // choose a stat from the list by name at random as the target for the positive change 
                // as long as it has not been used to its limit (its key is still inside list of options)
                randomIndex = new Random(Guid.NewGuid().GetHashCode()).Next(0, options.Count);
                targetStatName = options.ElementAt(randomIndex);

                // find the target stat in the weapon's current values
                targetStatCurrentValue = currentStats[targetStatName];

                // once the stat is located, find its current numerical value
                newStatValues = possibleStats[targetStatName];

                // now find the index of that numerical value inside its stat's list of other possible values  
                baseStatIndex = Array.IndexOf(newStatValues, targetStatCurrentValue);

                // and finally increment the value found there by one index
                weapon.GetType().GetProperty(targetStatName).SetValue(weapon, newStatValues[baseStatIndex + 1]);

                // must update current stats by adding the new current value
                // of the target stat, to keep up with multiple positive stat buffs
                currentStats[targetStatName] = newStatValues[baseStatIndex + 1];
                formWeaponGenerator.tbConsole.Text += weaponName + "\'s [" + targetStatName.ToUpper() + "] value was increased.\r\n";

                // take this stat away from the pool of target names to avoid surpassing its buff limit
                previouslyChangedStats.Add(targetStatName);
                options.Remove(targetStatName);
            }


            // remove any 5 value stats that were only triggered once
            foreach (string entry in previouslyChangedStats)
            {
                if (options.Contains(entry))
                {
                    options.Remove(entry);
                }
            }

            // for each negative change to be made...
            for (int negativeCounter = negatives; negativeCounter > 0; negativeCounter--)
            {
                // choose a stat from the list by name at random as the target for the negative change 
                // as long as it has not been used to its limit (its key is still inside list of options)
                randomIndex = new Random(Guid.NewGuid().GetHashCode()).Next(0, options.Count);
                targetStatName = options.ElementAt(randomIndex);

                // find the target stat in the weapon's current values
                targetStatCurrentValue = currentStats[targetStatName];

                // once the stat is located, find its current numerical value
                newStatValues = possibleStats[targetStatName];

                // now find the index of that numerical value inside its stat's list of other possible values  
                baseStatIndex = Array.IndexOf(newStatValues, targetStatCurrentValue);

                // and finally increment the value found there by one index
                weapon.GetType().GetProperty(targetStatName).SetValue(weapon, newStatValues[baseStatIndex - 1]);

                // must update current stats by adding the new current value
                // of the target stat, to keep up with multiple negative stat buffs
                currentStats[targetStatName] = newStatValues[baseStatIndex - 1];
                formWeaponGenerator.tbConsole.Text += weaponName + "\'s [" + targetStatName.ToUpper() + "] value was decreased.\r\n";

                // take this stat away from the pool of target names to avoid surpassing its buff limit
                options.Remove(targetStatName);
            }

            formWeaponGenerator.tbConsole.Text += "\r\n";
        }
    }
}
