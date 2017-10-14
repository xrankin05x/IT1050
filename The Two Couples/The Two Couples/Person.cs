using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Two_Couples
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string MartialStatus;
        public string Spouse;
        public int YearsOld;

        public static double SumOfAllAges;


        public string GetFullName()
        {
            string fullName = "";
            fullName += this.FirstName;
            fullName += "  ";
            fullName += " ";
            fullName += this.LastName;
            return fullName;
        }
            
                public int AverageAllAges()
        {
            return this.Age + YearsOld / 4;
        }
           public void PrintNameAndAge()
        {
                       
            System.Console.WriteLine("My name is " + this.GetFullName());
            System.Console.WriteLine("My age is " + this.Age);

        }
        


    }
}
