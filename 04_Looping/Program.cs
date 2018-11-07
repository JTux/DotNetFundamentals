using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Looping
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (number <= 100)
            {
                Console.WriteLine(number);
                number = number + 5;
            }

            int number2 = 100;
            for (int i = 1; i <= number2; i++)
            {
                Console.WriteLine(i);
            }

            for (int c = 1; c <= 525; c++)
            {
                Console.WriteLine(c);
            }

            Console.ReadLine();
            //for loop
            //for (int i = 0; i < 5; i += 2)
            //{
            //    Console.WriteLine(i);
            //}


            //foreach loop


            //while loop


        }
    }
}
