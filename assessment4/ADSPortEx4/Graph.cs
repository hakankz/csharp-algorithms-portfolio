using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx4
{
    //Graph implementation for Assessed Exercise 4

    //Hints : 
    //Use lecture materials from Week 9A
    // and lab sheet 'Lab 9: Graphs Implementation' to aid with base implementation.

    //For 4B, review material from lecture 9B and lab 10 to aid with the implementation of these metrics

    //For 4C, see lecture 10A and lab 10 to aid with your traversal implementation

    class Graph<T> where T : IComparable
    {
        private LinkedList<GraphNode<T>> nodes;

        public Graph()
        {
            nodes = new LinkedList<GraphNode<T>>();
        }

        //Functions for EX.4A

        public void AddNode(T id)
        {
            GraphNode<T> n = new GraphNode<T>(id);
            nodes.AddFirst(n);
        }

        private GraphNode<T> GetNodeByID(T id)
        {
            foreach (GraphNode<T> n in nodes)
            {
                if (n.ID.CompareTo(id) == 0)
                    return n;
            }
            return null;
        }

        public void AddEdge(T from, T to)
        {
            GraphNode<T> n1 = GetNodeByID(from);
            GraphNode<T> n2 = GetNodeByID(to);
            if (n1 != null && n2 != null)

                n1.AddEdge(n2);

        }

        public int NumNodes()
        {
            return nodes.Count;
        }

        public int NumEdges()
        {
            int edgeCount = 0;
            foreach (GraphNode<T> n in nodes)
            {
                edgeCount += n.GetAdjList().Count;
            }
            return edgeCount;
        }

        //Functions for EX.4B

        public void AddWeightedEdge(T from, T to, int weight)
        {
            GraphNode<T> n1 = GetNodeByID(from);
            GraphNode<T> n2 = GetNodeByID(to);

            if (n1 != null && n2 != null)
            {
                n1.AddEdgeWithWeight(n2, weight);
            }
        }

        public double AverageOutbound()
        {
            if (nodes.Count == 0)
                return 0;

            int totalEdges = 0;

            foreach (GraphNode<T> n in nodes)
            {
                totalEdges += n.GetAdjList().Count;
            }

            return (double)totalEdges / nodes.Count;

        }

        public double AverageTravelTime()
        {
            int totalWeight = 0;
            int totalEdges = 0;

            foreach (GraphNode<T> n in nodes)
            {
                foreach (int w in n.GetWeights())
                {
                    totalWeight += w;
                    totalEdges++;
                }
            }

            if (totalEdges == 0)
                return 0;

            return (double)totalWeight / totalEdges;
        }

        public List<T> GetAllConnections(T id)
        {
            GraphNode<T> node = GetNodeByID(id);

            if (node == null)
                return new List<T>();

            return node.GetAdjList().ToList();
        }

        //Functions for EX.4C

        public void BFS(T startID, ref List<T> visited)
        {
            throw new NotImplementedException();
        }

        public void DFS(T startID, ref List<T> visited)
        {
            throw new NotImplementedException();
        }

        public void FastestRoute(T startID, ref List<T> visited)
        {
            throw new NotImplementedException();
        }


        //Free space, use as needed




    }//End of class
}
