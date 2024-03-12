using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3
{
    internal class Bird : Animal
    {
        public int colors;
        public Bird(string name, int age, double weight, int colors)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.colors = colors;
        }

        public override void DoSound()
        {
            Console.WriteLine("Caw caw!");
        }

        public override string Stats()
        {
            return $"{base.Stats()} uniqe colors: {colors}";
        }
    }
}
