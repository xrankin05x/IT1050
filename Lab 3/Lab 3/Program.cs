using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor John = new Instructor("John",  "Smith",  "English");
            Instructor Mike = new Instructor("Mike",  "Johnson",  "Math");

            Student Jane = new Student("Jane", "Mr. John");
            Student Joe = new Student("Joe", "Mr. John");
            Student Melissa = new Student("Melissa", "Mr. Mike");
            Student Matt = new Student("Matt", "Mr. Mike");





            System.Console.WriteLine();
            System.Console.ReadKey();

        }
    }
}
