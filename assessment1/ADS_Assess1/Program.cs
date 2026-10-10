using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS_Assess1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a Menu driven interface here so a user can interact with your implementations

            //I.e. while(true){
            // print to user - "Select an option"
            // "1. Add a new emergency call to the queue"
            // "2. Remove and display the oldest emergency call in the queue"
            // ... ect
            //}
            EmergencyQueue queue = new EmergencyQueue(4);
            while(true)
            {                 Console.WriteLine("Select an option:");

                Console.WriteLine("1. Add a new emergency call to the queue");
                Console.WriteLine("2. Dispatch and display the oldest emergency call in the queue");
                Console.WriteLine("3. Display the number of calls in the queue and list all current calls ");
                Console.WriteLine("4. Display the highest severity call");
                Console.WriteLine("5. Dispatch several calls from the queue");
                Console.WriteLine("6. Exit");

                string choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        Console.Write("Enter caller name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Emergeny type: ");
                        string type = Console.ReadLine();

                        Console.Write("Enter Severty level between 1 and 5: ");
                        int severity = Convert.ToInt32(Console.ReadLine());

                        EmergencyCall call = new EmergencyCall(name, type, severity);

                        int before= queue.Count();

                        queue.Enqueue(call);
                        if (queue.Count() > before)
                        {

                            Console.WriteLine("Emergency call added to the queue.");
                        }
                        break;

                        case "2":
                        if(queue.IsEmpty())
                        {
                            Console.WriteLine("The queue is empty.");
                        }
                        else
                        {
                            EmergencyCall next = queue.Peek();
                            Console.WriteLine("Next emergency call: ");
                            Console.WriteLine("Caller: " + next.CallerName + ", Type: " + next.EmergencyType + ", Severity: " + next.SeverityLevel);
                            queue.Dequeue();
                             
                            Console.WriteLine("Emergency call has been dispatched.");
                        }
                        break;

                        case "3":
                        Console.WriteLine("Number of calls in the queue: " + queue.Count());
                        Console.WriteLine("Current calls in the queue: " + queue.ToString());
                        break;

                        case "4":
                        EmergencyCall highest = queue.PeekHighestSeverity();
                        if (highest == null)
                        {
                            Console.WriteLine("No calls in the queue.");
                        }
                                                else
                        {
                            Console.WriteLine("Highest severity call: " + highest.ToString());
                        }
                        break;

                        case "5":
                        Console.WriteLine("Enter number of calls to dispatch: ");
                            int k = Convert.ToInt32(Console.ReadLine());

                        if(queue.IsEmpty())
                        {
                            Console.WriteLine("The queue is empty.");
                            break;
                        }
                       
                        {
                            int availableCalls = queue.Count();
                            if(k > availableCalls)
                            {
                                Console.WriteLine("There are not enough calls in the queue to dispatch " + k + " call(s).");
                                break;
                            }
                            queue.DequeueFirstKCalls(k);
                            Console.WriteLine(k + " calls have been dispatched.");
                        }
                        break;






                    case "6":
                        Console.WriteLine("GoodBye!");
                        return;

                }

            }





        }
    }
}
