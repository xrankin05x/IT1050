﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Occupant
    {
        private string Name;
        private double Weight;

        public Occupant(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;

             public string GetName()
            {
                return this.Name;
            }

             public double GetWeight()
            {
                return this.Weight;
            }
        }

    }
}
