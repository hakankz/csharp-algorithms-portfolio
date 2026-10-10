using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Create a Menu driven interface here so a user can interact with your implementations

            //I.e. while(true){
            // print to user - "Select an option"
            // "1. Add Loot Node"
            // "2. Add new edge... ect
            //}
            Graph<Station> graph = new Graph<Station>();
            while (true)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Add Station");
                Console.WriteLine("2. Add Edge between Stations");
                Console.WriteLine("3. View number of Stations");
                Console.WriteLine("4. Show edge count");
                Console.WriteLine("5. Add weighted edge between stations");
                Console.WriteLine("6. Show average outbound connections");
                Console.WriteLine("7. Show average travel time");
                Console.WriteLine("8. Show all connections for a station");
                Console.WriteLine("9. Exit");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                    {
                    case "1":
                        {
                            Console.Write("Enter station name: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter passenger capacity: ");
                            int passengerCapacity = Convert.ToInt32(Console.ReadLine());

                            Station station = new Station(name, passengerCapacity);
                            graph.AddNode(station);

                            Console.WriteLine("Station added.");
                            break;
                        }
                    case "2":
                        {
                            
                                    Console.Write("Enter FROM station name: ");
                                    string fromName = Console.ReadLine();

                                    Console.Write("Enter TO station name: ");
                                    string toName = Console.ReadLine();

                                    Station fromStation = new Station(fromName, 0);
                                    Station toStation = new Station(toName, 0);

                                    graph.AddEdge(fromStation, toStation);

                                    Console.WriteLine("Connection added (if both stations exist).");
                                    break;
                                }

                    case "3":
                        {
                            Console.WriteLine("Number of stations: " + graph.NumNodes());
                            break;
                        }


                    case "4":
                        {
                            Console.WriteLine("Number of edges: " + graph.NumEdges());
                            break;
                        }

                    case "5":
                        {
                            Console.Write("Enter FROM station name: ");
                            string fromName = Console.ReadLine();

                            Console.Write("Enter TO station name: ");
                            string toName = Console.ReadLine();

                            Console.Write("Enter travel time in minutes: ");
                            int weight = Convert.ToInt32(Console.ReadLine());

                            Station fromStation = new Station(fromName, 0);
                            Station toStation = new Station(toName, 0);

                            graph.AddWeightedEdge(fromStation, toStation, weight);

                            Console.WriteLine("Weighted edge added.");
                            break;
                        }
                        case "6":
                        {
                            Console.WriteLine("Average outbound connections: " + graph.AverageOutbound());
                            break;
                        }

                        case "7":
                        {
                            Console.WriteLine("Average travel time: " + graph.AverageTravelTime());
                            break;
                        }
                        
                        case "8":
                        {
                            Console.Write("Enter station name: ");
                            string name = Console.ReadLine();

                            Station station = new Station(name, 0);
                            List<Station> connections = graph.GetAllConnections(station);

                            if (connections.Count == 0)
                            {
                                Console.WriteLine("No connections found.");
                            }
                            else
                            {
                                Console.WriteLine("Connections:");
                                foreach (Station s in connections)
                                {
                                    Console.WriteLine(s);
                                }
                            }
                            break;
                        }

                    case "9":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;

                }



                        

            }
        }
    }
}
