using CodewarsChallenges.challenges;
using System;
using System.Collections;
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
            //LanguageManager languageManager = new LanguageManager(new TurkishRepository());
            //languageManager.SayHello("Muhammed YILMAZ");
            //Console.WriteLine(Permutations.SinglePermutations("aabb"));
            //var printPerm = Permutations.SinglePermutations("aabb");
            //var printSol = Permutations.SinglePermutations_bestSol("aabb");
            //foreach (var item in printPerm)
            //{
            //    Console.WriteLine(item);
            //}

            //PatientInfo MuhammedInfo = new PatientInfo(1)
            //{
            //    Name = "Muhammed",
            //    IsWell = true
            //};

            //MuhammedInfo.ShowPatientInfo();


            //Console.WriteLine(PigLatinGame.LatinLangGame("abc sad"));
            //Console.WriteLine(PigLatinGame.LatinLangGame("Pig latin is cool !"));


            List<string> iller = new List<string>
            {
                "Anakara",
                "Istanbul"
            };

            iller.ForEach(s => Console.WriteLine($"{s, 5:#####}"));
        }



    }
}
