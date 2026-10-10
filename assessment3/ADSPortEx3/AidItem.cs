using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx3
{
    //AidItem class implementation for Assessed Exercise 3

    //For use as part of EX.3C

    //Use slides from Week 8A regarding the knapsack algorithm example to aid with implementation

    class AidItem: IComparable
    {
        private string name;
        private int weight;
        private int priority;

        public AidItem(string name, int weight, int priority)
        {
            Name = name;
            Weight = weight;
            Priority = priority;

        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value != "")
                    name = value;
                else
                    Console.WriteLine("Item name cannot be empty.");

            }
        }

        public int Weight
        {
            get { return weight; }
            set
            {
                if (value >= 1 && value <= 50)
                    weight = value;
                else
                    Console.WriteLine("Weight must be between 1 and 50.");
            }
        }

        public int Priority
        {
            get { return priority; }
            set
            {
                if (value >= 1 && value <= 10)
                    priority = value;
                else
                    Console.WriteLine("priority level must be between 1 and 10.");
            }
        }

        public double PriorityRatio
        {
            get { return (double)priority / weight; }
        }

        public int CompareTo(object obj)
        {
            AidItem other = (AidItem)obj;
            return PriorityRatio.CompareTo(other.PriorityRatio);
        }

    }
}
