using System;
using System.Collections.Generic;

namespace _07_Repository_Method_Example_01
{
    public class ProgramUI
    {
        StreamingContentRepository _contentRepo = new StreamingContentRepository();

        public void Run()
        {
            RunMenu();
        }

        private void RunMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Choose an action:" +
                    "\n1. Create new show" +
                    "\n2. See current list" +
                    "\n3. Exit");

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:     //Create new content
                        CreateContent();
                        break;
                    case 2:     //Show current list
                        PrintContentList();
                        break;
                    case 3:     //Exit
                        isRunning = false;
                        Console.WriteLine("Thank you come again");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invalid response.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private void CreateContent()
        {
            StreamingContent newContent = new StreamingContent();
            Console.WriteLine("What is the title?");
            newContent.Title = Console.ReadLine();

            Console.WriteLine("\nWhat is the genre?");
            newContent.Genre = Console.ReadLine();

            Console.WriteLine("\nHow would you rate this? 1-5");
            newContent.Rating = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDoes this contain mature content? (y/n)");
            string response = Console.ReadLine().ToLower();
            if (response == "y")
            {
                newContent.IsMature = true;
            }
            else
            {
                newContent.IsMature = false;
            }
            _contentRepo.AddContentToList(newContent);
        }

        private void PrintContentList()
        {
            List<StreamingContent> contentList = _contentRepo.GetContentList();
            foreach(StreamingContent content in contentList)
            {
                Console.WriteLine(content.Title);
            }
        }
    }

}