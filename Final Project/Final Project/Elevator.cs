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
        private Occupant[] Occupants;

        public Elevator(int maxOccupants, double maxWeight)
        {
            this.MaxWeight = maxWeight;

            Occupants = new Occupant[maxOccupants];
            }
            public void AddOccupant(Occupant passenger, int index)
            {
                Occupants[index] = passenger;

             }
        public double GetCurrentWeight()
            {
            return this.MaxWeight;
                }
            public double IsOverMaxCapacity()
            {
                    return this.MaxWeight;
             }



            
    }
}
