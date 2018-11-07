using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenge_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //-- Declare/Initialize Person and Vehicle
            Person newUser = new Person();
            Vehicle newVehicle = new Vehicle();


            //-- Assign User Properties
            Console.Write("Enter your first name: ");
            newUser.FirstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            newUser.LastName = Console.ReadLine();

            Console.Write("Enter your age: ");
            newUser.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter your address: ");
            newUser.Address = Console.ReadLine();


            //-- Assign Car Properties
            Console.Write("Enter make of car: ");
            newVehicle.Make = Console.ReadLine();

            Console.Write("Enter model of car: ");
            newVehicle.Model = Console.ReadLine();

            Console.Write("Enter year of car: ");
            newVehicle.Year = int.Parse(Console.ReadLine());

            newVehicle.Owner = newUser;

            //-- Call properties from Vehicle
            Console.WriteLine(newVehicle.Owner.FirstName + " " + newVehicle.Owner.LastName);
        }
    }
}
