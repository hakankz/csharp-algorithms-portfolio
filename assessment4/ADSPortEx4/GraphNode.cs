using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx4
{
    //Graph node implementation for Assessed Exercise 2

    //Hints : 
    //Use lecture materials from Week 9A and lab sheet 'Lab 9: Graphs Implementation' to aid with base implementation...
    //Then see materials for week 10 when moving onto 4B


    class GraphNode<T>
    {
        private T id;
        private LinkedList<T> adjList;
        private LinkedList<int> weights;

        public GraphNode(T id)
        {
            this.id = id;
            adjList = new LinkedList<T>();
            weights = new LinkedList<int>();
        }

        //Functions for EX.4A

        public T ID
        {
            set { id = value; }
            get { return id; }

        }

        public void AddEdge(GraphNode<T> to)
        {
            adjList.AddFirst(to.ID);
        }

        public LinkedList<T> GetAdjList()
        {
            return adjList;
        }

        //Functions for EX.4B

        public void AddEdgeWithWeight(GraphNode<T> to, int weight)
        {
            adjList.AddFirst(to.ID);
            weights.AddFirst(weight);
        }
        public LinkedList<int> GetWeights()
        {
            return weights;
        }



    }// End of class
}
