using System;
using System.Collections.Generic;
using System.Text;

namespace CodewarsChallenges.challenges
{
    class LanguageManager
    {
        private IRepository repository;
        public LanguageManager(IRepository repository)
        {
            this.repository = repository;
        }

        public void SayHello(string name)
        {
            this.repository.SayHello(name);
        }
    }
}
