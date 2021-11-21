using System;
using System.Linq;

namespace CodewarsChallenges.challenges
{
    class PigLatinGame
    {
        //best solution : https://www.codewars.com/kata/520b9d2ad5c005041100000f/solutions/csharp
        public static string LatinLangGame(string str)
        {


            return String.Join(" ", str.Split(" ").Select(s => { s = char.IsPunctuation(s[0]) == false? s.Substring(1) + s[0] + "ay": s; return s; }));
        }
    }
}
