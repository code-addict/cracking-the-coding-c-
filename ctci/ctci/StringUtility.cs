using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctci
{
    public class StringUtility
    {
        public static bool IsUnique(string str)
        {
            var checker = 0;
            for(var i = 0; i < str.Length; i++)
            {
                var value = str[i] - 'a';
                if((checker & (1 << value)) > 0)
                {
                    return false;
                }
                checker |= (1 << value);
            }
            return true;
        }

        public static bool ArePermutationsOfEachOther(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            // assuming it's ascii
            int[] letters = new int[128];

            foreach(char c in str1)
            {
                letters[c]++;
            }

            foreach (char c in str2)
            {
                if (--letters[c] < 0)
                    return false;
            }
            return true;
        }

        public static string Urlify(string str, int trueLength)
        {
            // Should convert string to character array with true length according to ps.

            char[] charArray = new char[trueLength];
            var strLength = str.Length;

            var index = 0;
            foreach (var c in str)
            {
                charArray[index] = c;
                index++;
            }

            while (trueLength > 0)
            {
                if (charArray[strLength - 1] == ' ')
                {
                    charArray[trueLength - 1] = '0';
                    charArray[trueLength - 2] = '2';
                    charArray[trueLength - 3] = '%';

                    trueLength = trueLength - 3;
                }
                else
                {
                    charArray[trueLength - 1] = charArray[strLength - 1];

                    trueLength = trueLength - 1;
                }
                strLength = strLength - 1;
            }
            return new string(charArray);
        }
    }
}
