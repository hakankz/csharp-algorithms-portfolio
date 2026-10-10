using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx2
{
    //Binary Tree implementation for Assessed Exercise 2

    //Hints : 
    //Use lecture materials from Week 4B
    // and lab sheet 'Lab 5: BinTree and BSTree' to aid with implementation...

    class BinTree<T> where T : IComparable
    {
        protected Node<T> root;

        public BinTree()
        {
            root = null;
        }

        public BinTree(Node<T> node)
        {
            root = node;
        }


        //Functions for EX.2A
        public void InOrder(ref string buffer)
        {
            InOrder(root, ref buffer);
        }
        private void InOrder(Node<T> node, ref string buffer)
        {
            if (node != null)
            {
                InOrder(node.Left, ref buffer);
                buffer += node.Data.ToString() + Environment.NewLine;
                InOrder(node.Right, ref buffer);
            }
        }

        public void PreOrder(ref string buffer)
        {
            PreOrder(root, ref buffer);
        }

        private void PreOrder(Node<T> node, ref string buffer)
        {
            if (node != null)
            {
                buffer += node.Data.ToString() + Environment.NewLine;
                PreOrder(node.Left, ref buffer);
                PreOrder(node.Right, ref buffer);
            }
        }

        public void PostOrder(ref string buffer)
        {
            PostOrder(root, ref buffer);
        }
        private void PostOrder(Node<T> node, ref string buffer)
        {
            if (node != null)
            {
                PostOrder(node.Left, ref buffer);
                PostOrder(node.Right, ref buffer);
                buffer += node.Data.ToString() + Environment.NewLine;
            }
        }

        //Free space, use as necessary to address task requirements... 





    } // End of class
}
