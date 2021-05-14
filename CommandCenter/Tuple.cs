using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandCenter
{
    // tuples used as the value of the weapon dictionary
    // each weapon type (the dictionary key) will have a unique
    // set of stats, stored as a Tuple (the dictionary value)
    internal class Tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
    {
        public string classification;
        public string properties;
        public string damage;
        public string critRange;
        public double[] critPower { get; }
        public double[] range { get; }
        public string ROF;
        public double[] APCost { get; }
        public string CAP;
        public double[] DUR { get; }
        public double[] accuracy { get; }
        public int MSRP;

        // used as a constructor for the value of each dictionary item
        public Tuple(string classification, string properties, string damage, string critRange, double[] critPower, double[] range, string ROF, double[] APCost, string CAP, double[] DUR, double[] accuracy, int MSRP)
        {
            this.classification = classification;
            this.properties = properties;
            this.damage = damage;
            this.critRange = critRange;
            this.critPower = critPower;
            this.range = range;
            this.ROF = ROF;
            this.APCost = APCost;
            this.CAP = CAP;
            this.DUR = DUR;
            this.accuracy = accuracy;
            this.MSRP = MSRP;
        }
    }
}
