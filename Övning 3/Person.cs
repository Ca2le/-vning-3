﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3
{
  

    internal class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;
        public Person(string fName, string lName) {
                FName = fName;
                LName = lName;
            }
        public int Age
        {
            get { return age; }
            set { 
                if (value < 0)
                {
                    throw new ArgumentException("Age can't be negative");
                }
                age = value;
            }
        }
        public string FName
        {
            get { return fName; }
            set {
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("First name must be at least 2 characters long");
                }
                fName = value;
            }
        }
        public string LName
        {
            get { return lName; }
            set {
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Last name must be at least 3 characters long");
                }
                lName = value; 
            }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }

}
