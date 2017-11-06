using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Kim_R
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Santa";
            person1.LastName = "Claus";
            person1.Age = 75;
            person1.Spouse = "Sara";

            Person person2 = new Person();
            person2.FirstName = "Rudolph";
            person2.LastName = "Reindeer";
            person2.Age = 35;
            person2.Spouse = "Ruby";




            System.Console.WriteLine(person1.GetFullName());
            System.Console.WriteLine(person2.GetFullName());

             

            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();


            

        }
    }
}
