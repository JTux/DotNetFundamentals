using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Repository_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Show> allShows = new List<Show>();
            Person newPerson = new Person();
            ShowRepository showRepo = new ShowRepository(newPerson);

            Console.Write("Enter your name: ");
            newPerson.Name = Console.ReadLine();

            Console.Write("Enter your age: ");
            newPerson.Age = int.Parse(Console.ReadLine());

            bool addingShows = true;
            while (addingShows)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?" +
                    "\n1. Register new show/movie" +
                    "\n2. Add show to list" +
                    "\n3. See your playlist" +
                    "\n4. See all available shows" +
                    "\n5. Exit");

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Show newShow = new Show();
                        Console.WriteLine("Is this a show or movie?");
                        if (Console.ReadLine().ToLower() == "show")
                            newShow.IsShow = true;

                        Console.Write("Enter the title: ");
                        newShow.Title = Console.ReadLine();

                        Console.Write("Enter the rating (0.0 - 10.0)");
                        newShow.Rating = double.Parse(Console.ReadLine());

                        Console.Write("Enter the Genre: ");
                        newShow.Genre = Console.ReadLine();

                        allShows.Add(newShow);
                        Console.WriteLine($"{newShow.Title} registered.");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Which movie/show would you like to add to your list?");

                        int count = 0;
                        foreach (Show show in allShows)
                        {
                            count++;
                            Console.WriteLine($"{count}. {show.Title}");
                        }

                        int choice = int.Parse(Console.ReadLine());
                        showRepo.AddShowToList(allShows[(choice - 1)]);
                        Console.ReadLine();
                        break;
                    case 3:
                        foreach(Show show in newPerson.Playlist)
                        {
                            Console.WriteLine(show.Title);
                        }
                        Console.ReadLine();
                        break;
                    case 4:
                        foreach(Show show in allShows)
                        {
                            Console.WriteLine(show.Title);
                        }
                        break;
                    case 5:
                        addingShows = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
