using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3
{
    internal class Hedgehog : Animal
    {
        public int nrOfSpikes;
        public Hedgehog(string name, int age, double weight)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
        }
        public override string Stats()
        {
            return $"{base.Stats()} number of spikes: {nrOfSpikes}";
        }
    }
}
