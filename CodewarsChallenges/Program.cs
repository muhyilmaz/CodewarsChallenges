using CodewarsChallenges.challenges;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodewarsChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("3 4 + is {0}", ReversePolishNotation.Evaluate("3 4 +"));
            //PrimedNumber primedNumber = new PrimedNumber();
            //Console.WriteLine(ParseMoleculFormula.ParseMolecule("H2O(MgH2P)"));

            //RgbToHex rgbToHex = new RgbToHex(255, 255, 255);
            //Console.WriteLine(SumofDigits.DigitalRoot(12345));
            LanguageManager languageManager = new LanguageManager(new TurkishRepository());
            languageManager.SayHello("Muhammed YILMAZ");


        }


        
    }
}
