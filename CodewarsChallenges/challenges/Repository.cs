using System;
using System.Collections.Generic;
using System.Text;

namespace CodewarsChallenges.challenges
{
    class Repository : IRepository
    {
        public void SayHello(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
