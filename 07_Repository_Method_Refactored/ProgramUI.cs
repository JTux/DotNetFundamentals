using System;
using System.Collections.Generic;

namespace _07_Repository_Method_Refactored
{
    class ProgramUI
    {
        List<StreamContent> allShows;
        User newPerson;
        StreamContentRepository showRepo;

        public ProgramUI()
        {
            allShows = new List<StreamContent>();
            newPerson = new User();
            showRepo = new StreamContentRepository(newPerson);
        }

        public void Run()
        {
            RegisterUser();
            Menu();
        }

        private void Menu()
        {
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
                        RegisterStreamContent();
                        break;
                    case 2:
                        AddToPlaylist();
                        break;
                    case 3:
                        ViewPlaylist();
                        break;
                    case 4:
                        ViewAllShows();
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

        private void RegisterStreamContent()
        {
            StreamContent newShow = new StreamContent();
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
        }

        private void AddToPlaylist()
        {
            Console.Clear();
            if (allShows.Count > 0)
            {
                Console.WriteLine("Which movie/show would you like to add to your list?");

                int count = 0;
                foreach (StreamContent show in allShows)
                {
                    count++;
                    Console.WriteLine($"{count}. {show.Title}");
                }

                int choice = int.Parse(Console.ReadLine());
                showRepo.AddShowToList(allShows[(choice - 1)]);
            }
            else
            {
                Console.WriteLine("No registered shows/movies.");
            }
            Console.ReadLine();
        }

        private void ViewPlaylist()
        {
            foreach (StreamContent show in newPerson.Playlist)
            {
                Console.WriteLine(show.Title);
            }
            Console.ReadLine();
        }

        private void ViewAllShows()
        {
            foreach (StreamContent show in allShows)
            {
                Console.WriteLine(show.Title);
            }
            Console.ReadLine();
        }

        private void RegisterUser()
        {
            Console.Write("Enter your name: ");
            newPerson.Name = Console.ReadLine();

            Console.Write("Enter your age: ");
            newPerson.Age = int.Parse(Console.ReadLine());
        }
    }
}
