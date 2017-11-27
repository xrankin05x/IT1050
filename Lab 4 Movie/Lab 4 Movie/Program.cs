using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Movie
{
    class Program

        {

            static void Main(string[] args)
            {

           
            double matineeChild = 3.99;
            double matineeAdult = 5.99;
            double matineeSenior = 4.50;

            double eveningChild = 6.99;
            double eveningAdult = 10.99;
            double eveningSenior = 8.50;

            int childPrice;
            int adultPrice;
            int seniorPrice;

            double smallSoda = 3.50;
            double largeSoda = 5.99;
            double hotDog = 3.99;
            double popCorn = 4.50;
            double candy = 1.99;
    }
            int smallSodaCount = 0;
            int largeSodaCount = 0;
            int hotDogCount = 0;
            int popcornCount = 0;
            int candyCount = 0;

            double totalTicketCount = 0;

            System.Console.WriteLine("Welcome to the show");
            System.Console.WriteLine("Will this be a Matinee or Evening show?");
            System.Console.WriteLine("Select 1 for Matinee or 2 for Evening: ");

            int matineeTicket;
            matineeTicket = 1; 

             if (Matinee == "1")
            {
                double matineeChild = 3.99;
                double matineeAdult = 5.99;
                double matineeSenior = 4.50;

                Console.WriteLine("The user enter 1");
                System.Console.Write("How many child matinee tickets? ");
                matineeChild = double.Parse(System.Console.ReadLine());

                System.Console.Write("How many adult matinee tickets? ");
                matineeAdult = int.Parse(System.Console.ReadLine());

                System.Console.Write("How many senior matinee tickets? ");
                matineeSenior = int.Parse(System.Console.ReadLine());

                int totalTicketCount = matineeChild + matineeAdult + matineeSenior;
    }
            else 
            {
                double eveningChild = 6.99;
                double eveningAdult = 10.99;
                double eveningSenior = 8.50;

                Console.WriteLine("The user enter 2");   
                System.Console.Write("How many child evening tickets? ");
                eveningChild = double.Parse(System.Console.ReadLine());

                System.Console.Write("How many adult evening tickets? ");
                eveningAdult = double.Parse(System.Console.ReadLine());

                System.Console.Write("How many senior evening tickets? ");
                eveningSenior = double.Parse(System.Console.ReadLine());

                int totalTicketCount = eveningChild + eveningAdult + eveningSenior;

}      
                        
                           
                System.Console.Write("How many small sodas? ");
                smallSoda = double.Parse(System.Console.ReadLine());

                System.Console.Write("How many large sodas? ");
                largeSoda = double.Parse(System.Console.ReadLine());

                System.Console.Write("How many Popcorn? ");
                popCorn = double.Parse(System.Console.ReadLine());

                System.Console.Write("How many hot dogs? ");
                hotDog = double.Parse(System.Console.ReadLine());

                System.Console.Write("How many candy? ");
                candy = double.Parse(System.Console.ReadLine());

                double totalMoviePurchase = 0;

                Discount += Min(NumPopCorn, numSoda) * 2
            


            System.Console.WriteLine();
            System.Console.Write("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
