using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx2
{
    //Binary Search Tree implementation for Assessed Exercise 2

    //Hints : 
    //Use lecture materials from Week 5
    // and lab sheet 'Lab 5: BinTree and BSTree' to aid with implementation.

    class BSTree<T> : BinTree<T> where T : IComparable
    {

        public BSTree()
        {
            root = null;
        }

        //Functions for EX.2A
        public void InsertItem(T item)
        {
            InsertItem(item, ref root);
        }
        private void InsertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
                tree = new Node<T>(item);

            else if (item.CompareTo(tree.Data) < 0)
                InsertItem(item, ref tree.Left);

            else if (item.CompareTo(tree.Data) > 0)
                InsertItem(item, ref tree.Right);
        }


        public int Height()
        {
            return Height(root);
        }

        private int Height(Node<T> tree)
        {
            if (tree == null)
                return 0;
            else
            {
                return 1 + Max(Height(tree.Left), Height(tree.Right));
            }
        }
        private int Max(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        public T EarlieseGame()
        {
            return EarlieseGame(root);
        }
        private T EarlieseGame(Node<T> tree)
        {
            if (tree == null)
                return default(T);
            else
            {
                T leftMin = EarlieseGame(tree.Left);
                T rightMin = EarlieseGame(tree.Right);

                T min = tree.Data;

                if (leftMin != null && ((VideoGame)(object)leftMin).Releaseyear < ((VideoGame)(object)min).Releaseyear)
                    min = leftMin;


                if (rightMin != null && ((VideoGame)(object)rightMin).Releaseyear < ((VideoGame)(object)min).Releaseyear)
                    min = rightMin;


                return min;
            }
        }

        //Functions for EX.2B

        public int Count()
        {
            return Count(root);
        }

        private int Count(Node<T> tree)
        {
            if (tree == null)
                return 0;

            else
            {
                return 1 + Count(tree.Left) + Count(tree.Right);
            }



        }


        public void Update(T item)
        {
            Update(item, root);
        }
        private void Update(T item, Node<T> tree)
        {
            if (tree == null)
                return;

            if (item.CompareTo(tree.Data) < 0)
                Update(item, tree.Left);
            else if (item.CompareTo(tree.Data) > 0)
                Update(item, tree.Right);
            else
            {
                VideoGame existing = (VideoGame)(object)tree.Data;
                VideoGame updated = (VideoGame)(object)item;

                existing.Developer = updated.Developer;
                existing.Releaseyear = updated.Releaseyear;


            }
        }

        public void ListByYear(int year)
        {
            ListByYear(year, root);
        }
        private void ListByYear(int year, Node<T> tree)
        {
            if (tree == null)
                return;
            VideoGame vg = (VideoGame)(object)tree.Data;
            if
                (vg.Releaseyear == year)
                Console.WriteLine(vg.ToString());

            ListByYear(year, tree.Left);
            ListByYear(year, tree.Right);



        }



            //Free space, use as necessary to address task requirements... 


            // End of class
        }
}
