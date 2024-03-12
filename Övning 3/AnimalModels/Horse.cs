using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3
{
    internal class Horse : Animal
    {
        public int speed;
        public Horse(string name, int age, double weight, int speed)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.speed = speed;
        }

        public override void DoSound()
        {
            Console.WriteLine("Ne-e-i-i-i-i-i-ighhh!");
        }
        public override string Stats()
        {
            return $"{base.Stats()} km/h: {speed}";
        }
    }
}
