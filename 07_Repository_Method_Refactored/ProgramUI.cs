using System;
using System.Collections.Generic;

namespace _07_Repository_Method_Refactored
{
    class ProgramUI
    {
        List<StreamContent> allShows;
        User newPerson;
        StreamContentRepository showRepo;
        IConsole _console;

        public ProgramUI(IConsole console)
        {
            _console = console;
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
                _console.Clear();
                _console.WriteLine("What would you like to do?" +
                    "\n1. Register new show/movie" +
                    "\n2. Add show to list" +
                    "\n3. See your playlist" +
                    "\n4. See all available shows" +
                    "\n5. Exit");

                int input = int.Parse(_console.ReadLine());
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
                        _console.WriteLine("Invalid input");
                        _console.ReadLine();
                        break;
                }
            }
        }

        private void RegisterStreamContent()
        {
            StreamContent newShow = new StreamContent();
            _console.WriteLine("Is this a show or movie?");
            if (_console.ReadLine().ToLower() == "show")
                newShow.IsShow = true;

            _console.Write("Enter the title: ");
            newShow.Title = _console.ReadLine();

            _console.Write("Enter the rating (0.0 - 10.0)");
            newShow.Rating = double.Parse(_console.ReadLine());

            _console.Write("Enter the Genre: ");
            newShow.Genre = _console.ReadLine();

            allShows.Add(newShow);
            _console.WriteLine($"{newShow.Title} registered.");
            _console.ReadLine();
        }

        private void AddToPlaylist()
        {
            _console.Clear();
            if (allShows.Count > 0)
            {
                _console.WriteLine("Which movie/show would you like to add to your list?");

                int count = 0;
                foreach (StreamContent show in allShows)
                {
                    count++;
                    _console.WriteLine($"{count}. {show.Title}");
                }

                int choice = int.Parse(_console.ReadLine());
                showRepo.AddShowToList(allShows[(choice - 1)]);
            }
            else
            {
                _console.WriteLine("No registered shows/movies.");
            }
            _console.ReadLine();
        }

        private void ViewPlaylist()
        {
            foreach (StreamContent show in newPerson.Playlist)
            {
                _console.WriteLine(show.Title);
            }
            _console.ReadLine();
        }

        private void ViewAllShows()
        {
            foreach (StreamContent show in allShows)
            {
                _console.WriteLine(show.Title);
            }
            _console.ReadLine();
        }

        private void RegisterUser()
        {
            _console.Write("Enter your name: ");
            newPerson.Name = _console.ReadLine();

            _console.Write("Enter your age: ");
            newPerson.Age = int.Parse(_console.ReadLine());
        }
    }
}
