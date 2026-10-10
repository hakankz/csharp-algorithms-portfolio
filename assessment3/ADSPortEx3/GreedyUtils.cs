using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx3
{
    class GreedyUtils
    {
        //Greedy algorithm implementation for Assessed Exercise 3

        //Hints : 
        //Use lecture materials from Week 8 to aid with implementation.

        public static List<AidItem> GetGreedyLoudout(List<AidItem> items, double limit)
        {
            List<AidItem> chosen = new List<AidItem>();
            int totalWeight = 0;
            int totalPriority = 0;

            AidItem[] arr = items.ToArray();
            SortUtils.QuickSortGen(arr);

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (totalWeight + arr[i].Weight <= limit)
                {
                    chosen.Add(arr[i]);
                    totalWeight += arr[i].Weight;
                    totalPriority += arr[i].Priority;
                }
            }

            return chosen;

        }

    }
}
