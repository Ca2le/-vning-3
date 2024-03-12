using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3
{
    internal class Swan : Bird
    {
        int familySize;
        public Swan(string name, int age, double weight, int colors, in int familySize) : base(name, age, weight, colors)
        {
            this.familySize = familySize;
        }
        public override void DoSound()
        {
            Console.WriteLine("Greggreggreggre!");
        }

        public override string Stats()
        {
            return $"{base.Stats()} Family size: {familySize}";
        }
    }
}
