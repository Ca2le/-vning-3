using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3
{
    internal class Wolf : Animal
    {
        public bool canBeTamed;
        public Wolf(string name, int age, double weight, bool canBeTamed)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.canBeTamed = canBeTamed;
        }

        public override void DoSound()
        {
            Console.WriteLine("Awoooooooo-ooo-ooo-oooh!");
        }
        public override string Stats()
        {
            return $"{base.Stats()} tameble: {canBeTamed}";
        }
    }
}
