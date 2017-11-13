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

            Student Jane = new Student("Jane", 95,  "Mr. John");
            Student Joe = new Student("Joe", 85,  "Mr. John");
            Student Melissa = new Student("Melissa", 90,  "Mr. Mike");
            Student Matt = new Student("Matt", 92,  "Mr. Mike");






            System.Console.WriteLine(John.FirstName + " " + John.LastName + " " + John.CourseName);
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();

        }
        


        }
    }
