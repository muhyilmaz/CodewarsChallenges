using System;
using System.Collections.Generic;
using System.Text;

namespace CodewarsChallenges.challenges
{
    class PrimedNumber
    {
        public int _num;
        public PrimedNumber()
        {
            ShowToScreen();
        }

        public void ShowToScreen()
        {
            Console.WriteLine("Please give a number to find its primes: ");
            while (!int.TryParse(Console.ReadLine(), out _num))
            {
                Console.WriteLine("Wrong input... please enter a number:  ");

            }
            Console.WriteLine("Primed num is: {0}",Primed(_num));
        }

        public string Primed(int num)
        {
            string result = "";

            Dictionary<int, int> primes = new Dictionary<int, int>();

            for (int i = 2; i <= num; i++)
            {
                if (isPrime(i) && num % i == 0)
                {
                    primes.Add(i, 0);
                    while (num % i == 0)
                    {
                        num /= i;
                        primes[i]++;
                    }
                }

            }
            foreach (var p in primes)
            {
                if (p.Value == 1)
                {
                    result += $"({p.Key})";
                }
                else
                {
                    result += $"({p.Key}**{p.Value})";
                }
            }
            return result;
        }

        private bool isPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var limit = Math.Ceiling(Math.Sqrt(number)); //hoisting the loop limit

            for (int i = 2; i <= limit; ++i)
                if (number % i == 0)
                    return false;
            return true;

        }
    }
}
