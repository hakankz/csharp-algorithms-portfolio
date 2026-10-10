using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Create a Menu driven interface here so a user can interact with your implementations

            //I.e. while(true){
            // print to user - "Select an option"
            // "1. Add item to tree"
            // "2. Display all items... ect
            //}
            AVLTree<VideoGame> tree = new AVLTree<VideoGame>();

            while (true)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Add a new video game to the tree");
                Console.WriteLine("2. Display all items (InOrder / PreOrder / PostOrder)");
                Console.WriteLine("3. Display the earliest released game");
                Console.WriteLine("4. Display the height of the tree");
                Console.WriteLine("5. Display the count of games");
                Console.WriteLine("6. Update a video game's information");
                Console.WriteLine("7. List all games released in a specific year");
                Console.WriteLine("8. Remove a video game by title");
                Console.WriteLine("9. Exit");


                string choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        Console.Write("Enter Title: ");
                        string title = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(title))
                        {
                            Console.WriteLine("Title cannot be empty.");
                            break;
                        }

                        Console.Write("Enter Developer: ");
                        string developer = Console.ReadLine();

                        Console.Write("Enter Release Year: ");
                        int releaseyear;
                        while (!int.TryParse(Console.ReadLine(), out releaseyear))
                        {
                            Console.Write("Invalid input. Please enter a valid Release Year: ");
                        }

                        VideoGame newGame = new VideoGame(title, developer, releaseyear);
                        tree.InsertItem(newGame);
                        Console.WriteLine("Video game added successfully.");
                        break;

                        case "2":
                        Console.Write("Choose traversal order (in / pre / post): ");
                        string order = Console.ReadLine();
                        string buffer = "";
                        if (order == "in")
                            tree.InOrder(ref buffer);
                        else if (order == "pre")
                            tree.PreOrder(ref buffer);
                        else if (order == "post")
                            tree.PostOrder(ref buffer);
                        else
                        {
                            Console.WriteLine("Invalid option. Please type in, pre or post.");
                            break;
                        }
                        Console.WriteLine("Tree contents (" + order + "-order): " + buffer);
                        break;

                    case "3":
                        VideoGame earliest = tree.EarlieseGame();
                        if (earliest == null)
                        {
                            Console.WriteLine("The tree is empty. No games to display.");
                        }
                        else
                        {
                            Console.WriteLine("Earliest released game:");
                            Console.WriteLine("Title: " + earliest.Title);
                            Console.WriteLine("Developer: " + earliest.Developer);
                            Console.WriteLine("Release Year: " + earliest.Releaseyear);
                        }
                        break;

                       case "4":
                        int height = tree.Height();
                        Console.WriteLine("The current height of the tree is: " + height);
                        break;

                    case "5":
                        int count = tree.Count();
                        Console.WriteLine("The total number of video games in the tree is: " + count);
                        break;

                        case "6":
                            Console.Write("Enter the title of the game to update: ");
                            string upTitle = Console.ReadLine();
                        Console.Write("Enter new Developer: ");
                        string upDev = Console.ReadLine();
                        Console.Write("Enter new Release Year: ");
                        int upYear;
                        while (!int.TryParse(Console.ReadLine(), out upYear))
                        {
                            Console.Write("Invalid input. Please enter a valid Release Year: ");
                        }

                        VideoGame updateGame = new VideoGame(upTitle, upDev, upYear);
                        tree.Update(updateGame);
                        Console.WriteLine("Game updated (if found).");
                        break;

                        case "7":
                            Console.Write("Enter Release Year to list games: ");
                        int listYear;
                        while (!int.TryParse(Console.ReadLine(), out listYear))
                        {
                            Console.Write("Invalid input. Please enter a valid Release Year: ");
                        }

                        Console.WriteLine("Games released in " + listYear + ":");
                        tree.ListByYear(listYear);
                        break;

                        case "8":
                            Console.Write("Enter the title of the game to remove: ");
                        string remTitle = Console.ReadLine();
                        VideoGame removeGame = new VideoGame(remTitle, "", 0, false);
                        tree.RemoveItem(removeGame);
                        Console.WriteLine("Video game removed successfully (if it existed).");
                        break;


                    case "9":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;









                }



            }





        }
    }
}
