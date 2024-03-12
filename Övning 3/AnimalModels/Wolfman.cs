using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3
{
    internal class Wolfman : Wolf , IPerson
    {
        public Wolfman(string name, int age, double weight, bool canBeTamed) : base(name, age, weight, canBeTamed)
        {
        }

        public string Talk()
        {
            return "I am a wolfman!";
        }

        


    }

}
