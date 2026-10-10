using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Create a Menu driven interface here so a user can interact with your implementations

            //I.e. while(true){
            // print to user - "Select an option"
            // "1. Demo sort..."
            // "2. Add item for greedy algorithm... ect
            //}

            //You won't need to create either of the utils classes, both use static methods.

            //I.e. 
            //SortUtils.InsertSort();
            //GreedyUtils.GetGreedyManifesto();
            List<AidItem> items = new List<AidItem>();
            while (true)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Sort an array of integers");
                Console.WriteLine("2. Sort an array of strings");
                Console.WriteLine("3. Add new AidItem");
                Console.WriteLine("4. View all AidItems");
                Console.WriteLine("5. Execute greedy algorithm");
                Console.WriteLine("6. Exit");

                string choice = Console.ReadLine();
                Console.WriteLine();


                switch (choice)
                {
                    case "1":
                        {
                            Console.Write("Enter integers separated by commas: ");
                            string input = Console.ReadLine();

                            int[] arr = input
                                .Split(',')
                                .Select(x => int.Parse(x.Trim()))
                                .ToArray();

                            SortUtils.QuickSortGen(arr);

                            Console.WriteLine("Sorted array:");
                            for (int i = 0; i < arr.Length; i++)
                            {
                                Console.WriteLine(arr[i]);
                            }

                            break;
                        }

                    case "2":
                        {
                            Console.Write("Enter strings separated by commas: ");
                            string input = Console.ReadLine();

                            string[] arr = input
                                .Split(',')
                                .Select(x => x.Trim())
                                .ToArray();

                            SortUtils.QuickSortGen(arr);

                            Console.WriteLine("Sorted array:");
                            for (int i = 0; i < arr.Length; i++)
                            {
                                Console.WriteLine(arr[i]);
                            }

                            break;
                        }
                    case "3":
                        {
                            Console.Write("Enter item name: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter item weight: ");
                            int weight = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter item priority: ");
                            int priority = Convert.ToInt32(Console.ReadLine());

                            AidItem item = new AidItem(name, weight, priority);
                            items.Add(item);

                            Console.WriteLine("Item added.");
                            break;
                        }
                    case "4":
                        { 
                        if (items.Count == 0)
                        {
                            Console.WriteLine("No AidItems have been added yet.");
                        }
                        else
                        {
                            Console.WriteLine("Entered AidItems:");
                            for (int i = 0; i < items.Count; i++)
                            {
                                    Console.WriteLine(
                                           (i + 1) + ". " +
                                           items[i].Name +
                                           " | Weight: " + items[i].Weight +
                                           " | Priority: " + items[i].Priority +
                                           " | Ratio: " + items[i].PriorityRatio
                                 );

                                }
                            }
                        break;
                }
                    case "5":
                        {
                            List<AidItem> chosen = GreedyUtils.GetGreedyLoudout(items, 75);

                            int totalWeight = 0;
                            int totalPriority = 0;

                            Console.WriteLine("Selected items:");

                            for (int i = 0; i < chosen.Count; i++)
                            {
                                totalWeight += chosen[i].Weight;
                                totalPriority += chosen[i].Priority;

                                Console.WriteLine(
                                    (i + 1) + ") " + chosen[i].Name +
                                    ", weight = " + chosen[i].Weight +
                                    ", priority = " + chosen[i].Priority
                                );
                            }

                            Console.WriteLine("Total weight = " + totalWeight);
                            Console.WriteLine("Total priority = " + totalPriority);
                            break;
                        }

                    case "6":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;
                }

                Console.WriteLine();
            }

        }
    }
}
