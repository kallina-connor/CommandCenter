using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandCenter
{
    class Shuffler
    {
        // randomly selects an element from a list (one line from any file)
        public static string getRandomElement(string fileName)
        {
            List<string> options = createList(fileName);
            string item = options[new Random(Guid.NewGuid().GetHashCode()).Next(0, options.Count())];
            return item;
        }

        // make a file into a list to have an element programatically selected
        private static List<string> createList(string fileName)
        {
            string resource_data = (string) Properties.Resources.ResourceManager.GetObject(fileName);
            List<string> words = resource_data.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            return words;
        }
    }
}
