using System;

namespace _00_Challenge_01
{
    class Program
    {
        static string userName;
        static int userAge, accidentCount, mileage;
        static decimal totalCost;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Komodo Insurance");
            Register();
            bool running = true;
            while (running)
            {
                Console.Clear();

                Console.WriteLine("Welcome to Komodo Insurance\n" +
                    "Which action would you like to do?\n" +
                    "1. See Info\n" +
                    "2. Update Info\n" +
                    "3. Exit");

                int input = GetIntput();
                switch (input)
                {
                    case 1:
                        GetInfo();
                        Console.ReadKey();
                        break;
                    case 2:
                        UpdateInfo();
                        Console.ReadKey();
                        break;
                    case 3:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
        }

        private static int GetIntput()
        {
            string inputAsString = Console.ReadLine();
            int input = int.Parse(inputAsString);
            return input;
        }

        private static void Register()
        {
            Console.WriteLine("Enter your name: ");
            userName = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            userAge = GetIntput();

            Console.WriteLine("How many accidents have you been in?");
            accidentCount = GetIntput();

            Console.WriteLine("How many miles are on your car?");
            mileage = GetIntput();

            CalculateCost();
        }

        private static void GetInfo()
        {
            Console.WriteLine($"Hello {userName}! Your current information on file is:");
            Console.WriteLine($"Age: {userAge}");
            Console.WriteLine($"Recorded Accidents: {accidentCount}");
            Console.WriteLine($"Recorded Mileage: {mileage}");
            Console.WriteLine($"Monthly Premium: ${totalCost}");
        }

        private static void UpdateInfo()
        {
            Register();
        }

        private static void CalculateCost()
        {
            decimal ageCost;
            decimal mileCost;
            decimal accidentCost;

            if (userAge >= 25)
            {
                ageCost = 75;
            }
            else
            {
                ageCost = 125;
            }

            if (mileage > 100000)
            {
                mileCost = 100;
            }
            else if (mileage > 50000)
            {
                mileCost = 50;
            }
            else
            {
                mileCost = 0;
            }

            if (accidentCount > 0)
            {
                accidentCost = 25;
            }
            else
            {
                accidentCost = 0;
            }

            totalCost = ageCost + mileCost + accidentCost;
        }
    }
}
