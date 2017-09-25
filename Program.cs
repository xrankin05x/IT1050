
namespace Lab_1_7._19._17
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName;
            //string middleInitial;
            //string lastName;
            // string fullName;
            //int age;
            // bool isCitizen;
            //bool canVote;
            // int heightFeet;
            //double heightInches;
            // double totalHeightInCM


            System.Console.Write("What is your first name? ");
            string firstName;
            firstName = System.Console.ReadLine();
            System.Console.Write("What is your middle initial?");
            string middleInitial;
            middleInitial = System.Console.ReadLine();
            System.Console.Write("What is your last name? ");
            string lastName;
            lastName = System.Console.ReadLine();
            System.Console.Write("What is your full name? ");
            string fullName;
            fullName = System.Console.ReadLine();
            System.Console.Write("What is your height using feet only? ");
            int heightInFeet;
            heightInFeet = int.Parse(System.Console.ReadLine());
            System.Console.Write("What is your remaining height in inches? ");
            int heightInInches;
            heightInInches = int.Parse(System.Console.ReadLine());
            System.Console.Write("What is your total height? ");
            double totalHeightInches = (heightInFeet * 12) + heightInInches; 
            totalHeightInches = double.Parse(System.Console.ReadLine());
            System.Console.Write("What is your height in CM? ");
            double totalHeightCM = totalHeightInches * 2.54;
            totalHeightCM = double.Parse(System.Console.ReadLine());
            System.Console.Write("What is your age? ");
            int age;
            age = int.Parse(System.Console.ReadLine());
            System.Console.Write("Are you a Citizen? ");
            bool isCitizen = true;
            bool canVote = (isCitizen) && (age >= 21);






            System.Console.WriteLine(fullName);
            System.Console.ReadKey();
            


        }
    }
}
