using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Two_Couples
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Santa";
            person1.LastName = "Claus";
            person1.Age = 80;
            person1.MartialStatus = "yes";
            person1.Spouse = "Sara";
            person1.YearsOld = 76;

            Person person2 = new Person();
            person2.FirstName = "Rudolph";
            person2.LastName = "Reindeer";
            person2.Age = 48;
            person2.MartialStatus = "yes";
            person2.Spouse = "Rose";
            person2.YearsOld = 40;
            double avgage = (person1.Age + person1.YearsOld + person2.Age + person2.YearsOld) / 4;

            Console.WriteLine("Average Age:"+avgage);
            person1.PrintNameAndAge();
            person2.PrintNameAndAge();

           
            System.Console.WriteLine(person1.AverageAllAges());
            System.Console.WriteLine(person2.AverageAllAges());
            

            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}
