using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3
{
    internal abstract class Animal
    {
        public string name;
        public int age;
        public double weight;

        public virtual void DoSound()
        {
            Console.WriteLine("...");
        }

        public virtual string Stats()
        {
           return $"Name: {name}, Age: {age}, Weight: {weight}";
        }
    }

}
