using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes_Repository_Method
{
    class ProgramUI
    {
        private ShowRepository showRepo;
        private List<Show> shows;

        public ProgramUI()
        {
            showRepo = new ShowRepository();
            shows = showRepo.GetShows();
        }

        public void Run()
        {
            while (RunMenu()) { }
        }

        private bool RunMenu()
        {
            Console.Clear();
            Console.WriteLine($"What do you want to do?\n" +
                $"1. See all shows\n" +
                $"2. Add new show to list\n" +
                $"3. Exit");
            while (true)
            {
                switch (ParseIntput())
                {
                    case 1:
                        PrintAllShows();
                        return true;
                    case 2:
                        CreateNewShow();
                        return true;
                    case 3:
                        return false;
                    default:
                        return true;
                }
            }
        }

        private void PrintAllShows()
        {
            foreach (Show show in shows)
            {
                Console.WriteLine($"{show.Title} {show.Genre} {show.PlayTimeInMinutes}");
            }
            Console.ReadLine();
        }

        private void CreateNewShow()
        {
            Console.WriteLine("Enter new show title:");
            string title = Console.ReadLine();

            Console.WriteLine("Enter show runtime in minutes: ");
            int playTime = ParseIntput();

            Console.WriteLine("Enter genre number:\n" +
                "1. Drama\n" +
                "2. Mystery\n" +
                "3. RomCom");
            int genreInput = ParseIntput();

            ShowGenre genre;
            switch (genreInput)
            {
                case 1:
                    genre = ShowGenre.Drama;
                    break;
                case 2:
                    genre = ShowGenre.Mystery;
                    break;
                default:
                    genre = ShowGenre.RomCom;
                    break;
            }

            Show newShow = new Show(title, playTime, genre);
            showRepo.AddShowToList(newShow);
            Console.WriteLine($"\"{title}\" added to list.");
            Console.ReadLine();
        }

        private int ParseIntput()
        {
            int input = int.Parse(Console.ReadLine());
            return input;
        }
    }
}
