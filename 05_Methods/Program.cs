using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringInput = Console.ReadLine();
            int value = int.Parse(stringInput);
            int input = int.Parse(Console.ReadLine());

            bool exit = false;
            while(exit != true)
            {

            }
        }

        private int ParseIt()
        {
            string input = Console.ReadLine();
            int output = int.Parse(input);
            return output;
        }

        private int Add(int number1, int number2)
        {
            int number3 = number1 + number2;
            return number3;
        }

        private void SayHi(string name)
        {
            Console.WriteLine($"Hi {name}!");
            Console.WriteLine("Hi {0}!", name);
        }
    }
}
