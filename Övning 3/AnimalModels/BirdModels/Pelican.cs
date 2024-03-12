using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3
{
    internal class Pelican : Bird
    {
        public int mouthSize;
        public Pelican(string name, int age, double weight, int colors, int mouthSize) : base(name, age, weight, colors)
        {
            this.mouthSize = mouthSize;
        }

        public override void DoSound()
        {
            Console.WriteLine("Squawk squawk!");
        }

        public override string Stats()
        {
            return $"{base.Stats()} Size of mouth: {mouthSize}";
        }
    }
}
