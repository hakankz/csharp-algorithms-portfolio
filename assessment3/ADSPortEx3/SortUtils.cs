using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx3
{
    //Generic QuickSort implementation for Assessed Exercise 3

    //Hints : 
    //Use lecture materials from Week 7 to aid with implementation.

    //Use the provided QuickSort function as a starting point for
    // adjusting the functionality to make it generic. Make use of IComparable
    // as you have done during other structure implementations

    //Your implemented function can be utilised as part EX.3C

    class SortUtils
    {
        static void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }


        static public void QuickSort(int[] items, int left, int right)
        {
            int i, j;
            i = left; j = right;
            int pivot = items[left];

            while (i <= j)
            {
                for (; (items[i] < pivot) && (i < right); i++) ;
                for (; (pivot < items[j]) && (j > left); j--) ;

                if (i <= j)
                    swap(ref items[i++], ref items[j--]);
            }

            if (left < j) QuickSort(items, left, j);
            if (i < right) QuickSort(items, i, right);
        }


        static public void QuickSortGen<T>(T[] a) where T : IComparable
        {
            if (a == null || a.Length <= 1) return;
            QuickSortGen(a, 0, a.Length - 1);
        }
        static private void QuickSortGen<T>(T[] items, int left, int right) where T : IComparable
        {
            int i, j;
            i = left; j = right;
            T pivot = items[left];
            while (i <= j)
            {
                for (; (items[i].CompareTo(pivot) < 0) && (i < right); i++) ;
                for (; (pivot.CompareTo(items[j]) < 0) && (j > left); j--) ;
                if (i <= j)
                    swap(ref items[i++], ref items[j--]);

            }
            if (left < j) QuickSortGen(items, left, j);
            if (i < right) QuickSortGen(items, i, right);

        }



    }
}
