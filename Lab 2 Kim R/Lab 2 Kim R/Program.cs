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
            person1.MaritalStatus = "yes";
            person1.Spouse = "Sarah";
            person1.AgeSpouse = 70;

            Person person2 = new Person();
            person2.FirstName = "Rudolph";
            person2.LastName = "Deer";
            person2.Age = 35;
            person2.MaritalStatus = "yes";
            person2.Spouse = "Ruby";
            person2.AgeSpouse = 33;


            

            System.Console.WriteLine(person1.GetFullName());
            System.Console.WriteLine(person2.GetFullName());

            System.Console.WriteLine(person1.GetSumOfAllAges());
            System.Console.WriteLine(person2.GetSumOfAllAges());

            System.Console.WriteLine("Press any key. ..");
            System.Console.ReadKey();


            

        }
    }
}
