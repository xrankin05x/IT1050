using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator1 = new Elevator (2, 400);

            Occupant[0] = new Occupant("A1", 180);
            Occupant[0].Set(01);

            Occupant[1] = new Occupant("A2", 220);
            Occupant[1].Set(2);

            bool elevator1IsOverMaxCapacity; 

            elevator1IsOverMaxCapacity = IsOverMaxCapacity.elevator1;

            Elevator elevator2 = new Elevator(3, 600);

            Occupant[0] = new Occupant("A1", 200);
            Occupant[0].Set(01);

            Occupant[1] = new Occupant("A2", 200);
            Occupant[1].Set(2);

            Occupant[2] = new Occupant("A3", 201);
            Occupant[2].Set(2);

            bool elevator2IsOverMaxCapacity;
            elevator2IsOverMaxCapacity = IsOverMaxCapacity.elevator2;

        }

        private class IsOverMaxCapacity
        {
        }
    }
}
