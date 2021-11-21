using System;
using System.Collections.Generic;
using System.Text;

namespace CodewarsChallenges.challenges
{
    class PatientInfo
    {
        public int Id { get; }
        public string Name { get; set; }
        public bool IsWell { get; set; }

        public PatientInfo(int id)
        {
            Id = id;
        }

        public void ShowPatientInfo()
        {
            string strIsWell = IsWell == true ? "iyi" : "kötü";
            Console.WriteLine($"{Id} No'lu {Name} isimli hastanın durumu {strIsWell}");
        }
    }
}
