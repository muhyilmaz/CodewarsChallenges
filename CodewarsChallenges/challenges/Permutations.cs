using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodewarsChallenges.challenges
{
    class Permutations
    {

        public static List<string> SinglePermutations_bestSol(string s)
        {
            return $"{s}".Length < 2 ? new List<string> { s } : SinglePermutations_bestSol(s.Substring(1))
            .SelectMany(x => Enumerable.Range(0, x.Length + 1)
            .Select((_, i) => x.Substring(0, i) + s[0] + x.Substring(i)))
            .Distinct()
            .ToList();
        }

        public static string Swap(string str, int i, int j)
        {
            char temp;
            char[] charArray = str.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;

            return new string(charArray);
        }

        public static List<string> Calculate(string str, int left, int right, List<string> result)
        {
            if (left == right)
            {
                //return same string
                result.Add(str);
            }
            else
            {
                for (int i = left; i <= right; i++)
                {
                    string swapped = Swap(str, left, i);
                    Calculate(swapped, left + 1, right, result);
                }
            }
            return result;
        }

        public static List<string> SinglePermutations(string s)
        {
            List<string> result = new List<string>();
            Calculate(s, 0, s.Length - 1, result);

            return result.Distinct().ToList();
        }
    }
}
