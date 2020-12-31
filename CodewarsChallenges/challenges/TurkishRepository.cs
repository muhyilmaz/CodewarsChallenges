using System;
using System.Collections.Generic;
using System.Text;

namespace CodewarsChallenges.challenges
{
    class TurkishRepository : IRepository
    {
        public void SayHello(string name)
        {
            Console.WriteLine("Merhaba" + name);
        }
    }
}
