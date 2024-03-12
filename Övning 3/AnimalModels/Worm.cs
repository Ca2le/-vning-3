using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3
{
    internal class Worm : Animal
    {
        public bool isDangerous;
        public Worm(string name, int age, double weight, bool isDangerous)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.isDangerous = isDangerous;
        }
        public override string Stats()
        {
            return $"{base.Stats()} dangerous: {isDangerous}";
        }
    }
}
