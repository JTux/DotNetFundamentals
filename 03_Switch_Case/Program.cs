using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How are you feeling on a scale of 1-5?");
            int feeling = int.Parse(Console.ReadLine());

            if(feeling == 1)
            {
                Console.WriteLine("Oh no that's terrible");
            }
            else if(feeling == 2)
            {
                Console.WriteLine("Uh oh");
            }
            else if (feeling == 3)
            {
                Console.WriteLine("Interesting");
            }
            else if (feeling == 4)
            {
                Console.WriteLine("That's good");
            }
            else if (feeling == 5)
            {
                Console.WriteLine("Awesome!");
            }
            else
            {
                Console.WriteLine("That's off the scale");
            }
            Console.ReadLine();




            switch (feeling)
            {
                case 1:
                Console.WriteLine("Oh no that's terrible");
                    break;
                case 2:
                Console.WriteLine("Uh oh");
                    break;
                case 3:
                Console.WriteLine("Interesting");
                    break;
                case 4:
                Console.WriteLine("That's good");
                    break;
                case 5:
                Console.WriteLine("Awesome!");
                    break;
                default:
                Console.WriteLine("That's off the scale");
                    break;
            }
            Console.ReadLine();




            int number = 10;

            if (number == 7)
                Console.WriteLine("The number is 7.");
            else
                Console.WriteLine("The number is not 7.");

            string response = ((number == 7) ? "The number is 7." : "The number is not 7.");
            Console.WriteLine(response);

            Console.ReadLine();
        }
    }
}
