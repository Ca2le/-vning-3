using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3
{
    internal class Dog : Animal
    {
        public int nrOfTricks;
        public Dog(string name, int age, double weight, int nrOfTricks)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.nrOfTricks = nrOfTricks;
        }
        public override void DoSound()
        {
            Console.WriteLine("Woof! Woof!");
        }
        public override string Stats()
        {
            return $"{base.Stats()} number of tricks: {nrOfTricks}";
        }
        public string bestDogFood()
        {
            return "Bacon";
        }
    }
}
