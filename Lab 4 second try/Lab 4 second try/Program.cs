﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_second_try
{
    class Program
    {
        

        
        static void Main(string[] args)
        {   ShowMainMenu();
            ShowInputPrompt();

            string command = Console.ReadLine();

            Console.Write("Enter a number: ");

          
            double totalTicketCost = 0;
            double totalFoodCost = 0;

            if (command == "1")
            { 
                double childCost = 3.99;
                double adultCost = 5.99;
                double seniorCost = 4.50;
            
                Console.WriteLine();
                Console.Write("How many child matinee");
                int childMatinee = int.Parse(Console.ReadLine());

                Console.Write("How many adult matinee");
                int adultMatinee = int.Parse(Console.ReadLine());

                Console.Write("How many senior matinee");
                int seniorMatinee = int.Parse(Console.ReadLine());

                double totalTicketCount = childCost + adultCost + seniorCost;
            }
            else if ( command == "2" )
            {
                double childCost = 6.99;
                double adultCost = 10.99;
                double seniorCost = 8.50;

                Console.WriteLine();
                Console.Write("How many child evening");
                int childMatinee = int.Parse(Console.ReadLine());

                Console.Write("How many adult evening");
                int adultMatinee = int.Parse(Console.ReadLine());

                Console.Write("How many senior evening");
                int seniorMatinee = int.Parse(Console.ReadLine());

                double totalTicketCount = childCost + adultCost + seniorCost;

                Console.WriteLine();
                Console.WriteLine(" Press any key to continue...");
                Console.WriteLine();
                Console.WriteLine(" ");
                Console.ReadKey();

            }




            private static void ShowMainMenu()
            {
                Console.WriteLine();
                Console.WriteLine("+------------------------------------------+");
                Console.WriteLine("| Please choose from the follwing options:|" );
                Console.WriteLine("+------------------------------------------+");
                Console.WriteLine("| (1) - Matinee Tickets                     ");
                Console.WriteLine("| (2) - Evening Tickets                     ");
                Console.WriteLine("+------------------------------------------+");
                
            }
        }

        private static void ShowInputPrompt()
        {
            throw new NotImplementedException();
        }
    }
}
