using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandCenter
{
    class Job
    {
        string classification;
        string category;
        string subcategory;
        string name;
        public static List<String> parameters;

        public Job (string cl, string ca, string sc, string n)
        {
            this.classification = cl;
            this.category = ca;
            this.subcategory = sc;
            this.name = n;
            parameters = new List<String>();
        }
    }
}
