using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandCenter
{
    internal class KeyValuePair
    {
        private string dictionaryKey;
        private Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int> dictionaryValue;

        public KeyValuePair(string dictionaryKey, Tuple<string, string, string, string, double[], double[], string, double[], string, double[], double[], int> dictionaryValue)
        {
            this.dictionaryKey = dictionaryKey;
            this.dictionaryValue = dictionaryValue;
        }
    }
}
