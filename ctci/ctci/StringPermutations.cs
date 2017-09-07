using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctci
{
    public class StringPermutations
    {
        public void Permutations(string str)
        {
            var outList = new List<string>();
            Permutations("", str, outList);

        }

        public void Permutations(string prefix, string str, List<string> allStrings)
        {
            if (str.Length == 0)
            {
                allStrings.Add(prefix);
            }
            for (var i = 0; i < str.Length; i++)
            {
                Permutations(prefix + str.Substring(i, 1), str.Substring(0, i) + str.Substring(i + 1, str.Length - (i + 1)), allStrings);
            }
        }
    }
}
