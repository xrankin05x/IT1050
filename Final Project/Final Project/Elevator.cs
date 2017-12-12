using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupants;

        public Elevator(int maxOccupants, double maxWeight);

        public Elevator(double maxWeight, Passenger[] occupants)
        {
            MaxWeight = maxWeight;
            Occupants = occupants;
        }
    }
}
