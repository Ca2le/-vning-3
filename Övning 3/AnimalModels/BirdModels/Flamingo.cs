using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3
{
    internal class Flamingo : Bird
    {
        public int legLength;
        public Flamingo(string name, int age, double weight, int colors, int legLength) : base(name, age, weight, colors)
        {
            this.legLength = legLength;
        }

        public override void DoSound()
        {
            Console.WriteLine("Honk honk!");
        }

        public override string Stats()
        {
            return $"{base.Stats()} Leg length: {legLength}";
        }
    }
}
