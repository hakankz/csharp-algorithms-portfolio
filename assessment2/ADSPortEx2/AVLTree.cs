using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx2
{
    //AVL Tree implementation for Assessed Exercise 2

    //Hints : 
    //Use lecture materials from Week 6A
    // and lab sheet 'Lab 6: AVL Trees' to aid with implementation...

    //You may need to adjust your other tree classes to allow your AVL tree
    // access to certain attributes and functions

    class AVLTree<T> : BSTree<T> where T : IComparable
    {

        //Functions for EX.2C
        public new void InsertItem(T item)
        {
            InsertItem(item, ref root);
        }

        private void InsertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
            {
                tree = new Node<T> (item);
                return;
            }
            if (item.CompareTo(tree.Data) < 0)
                InsertItem(item, ref tree.Left);
            else if (item.CompareTo(tree.Data) > 0)
                InsertItem(item, ref tree.Right);
            else
                return;

            updateBalanceFactor(tree);

            if (tree.BalanceFactor <= -2)
                rotateLeft(ref tree);
            else if (tree.BalanceFactor >= 2)
                rotateRight(ref tree);

            updateBalanceFactor(tree);

        }

        public new void RemoveItem(T item)
        {
            RemoveItem(item, ref root);
        }

        private void RemoveItem(T item, ref Node<T> tree)
        {
            if (tree == null)
                return;
            if (item.CompareTo(tree.Data) < 0)
            {
                RemoveItem(item, ref tree.Left);
            }

            else if (item.CompareTo(tree.Data) > 0)
            {
                RemoveItem(item, ref tree.Right);
            }
            else
            {
                if (tree.Left == null && tree.Right == null)
                {
                    tree = null;
                    return;
                }
                 if (tree.Left == null && tree.Right != null)
                {
                    tree = tree.Right;
                    return;
                }
                if (tree.Right == null && tree.Left != null)
                {
                    tree = tree.Left;
                    return;
                }
                else
                {
                    T newRoot = leastItem(tree.Right);
                    tree.Data = newRoot;
                    RemoveItem(newRoot, ref tree.Right);

                }

                }
            updateBalanceFactor(tree);
            if (tree.BalanceFactor <= -2)
                rotateLeft(ref tree);
            else if (tree.BalanceFactor >= 2)
                rotateRight(ref tree);
            updateBalanceFactor(tree);



        }

        private T leastItem(Node<T> tree)
        {
            if (tree.Left == null)
                return tree.Data;
            else
                return leastItem(tree.Left);
        }   

        //Free space, use as required

        private int height(Node<T> tree)
        {
            if (tree == null)
                return 0;
            else
                return max(height(tree.Left), height(tree.Right)) + 1;
        }
        private int max(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        private void updateBalanceFactor(Node<T> tree)
        {
            if (tree != null)
                tree.BalanceFactor = height(tree.Left) - height(tree.Right);
        }   

        private void rotateRight(ref Node<T> tree)
        {
            if (tree.Left.BalanceFactor < 0)
                rotateLeft(ref tree.Left);

            Node<T> newRoot = tree.Left;
            tree.Left = newRoot.Right;
            newRoot.Right = tree;
            tree = newRoot;
        }
        private void rotateLeft(ref Node<T> tree)
        {
            if (tree.Right.BalanceFactor > 0)
                rotateRight(ref tree.Right);

            Node<T> newRoot = tree.Right;
            tree.Right = newRoot.Left;
            newRoot.Left = tree;
            tree = newRoot;
        }





    }// End of class
}
