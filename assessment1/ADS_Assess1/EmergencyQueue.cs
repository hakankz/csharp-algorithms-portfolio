using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS_Assess1
{
    //Queue implementation for Assessed Exercise 1

    //Please use lecture and lab materials from Week 2A to aid with implementation.

    //Do not delete the current function definitions, just replace the exceptions with the required functionality.

    // Don't forget to properly commit and document your work. 
    // Commit fairly frequently with proper descriptions, i.e. commit after implementing the enqueue function...

    internal class EmergencyQueue
    {
        private int maxsize = 10;
        private EmergencyCall[] store;
        private int head;
        private int tail;
        private int numitems;

        // Functions for EX.1A
        public EmergencyQueue()
        {
            store = new EmergencyCall[maxsize];
        }

        public EmergencyQueue(int size)
        {
            maxsize = size;
            store = new EmergencyCall[maxsize];
        }

        public void Enqueue(EmergencyCall value)
        {
            if(IsFull())
            {
                Console.WriteLine("The queue has reached the maximum number of calls (" + maxsize + ").");
                return;
            }
            store[tail] = value;
            tail++;
            numitems++;

            if (tail == maxsize)
            {
                tail = 0;
            }

        }

        public EmergencyCall Dequeue()
        {
            EmergencyCall headitem;
            headitem = store[head];
            head++;
            numitems--;
            if (head == maxsize)
            {
                head = 0;
            }


            return headitem;
        }

        public EmergencyCall Peek()
        {
            EmergencyCall headitem;
            headitem = store[head];
            return headitem;
        }

        public int Count()
        {
            return numitems;
        }

        public bool IsEmpty()
        {
            return numitems == 0;
        }

        public bool IsFull()
        {
            return numitems == maxsize;
        }

        public override string ToString()
        {
            string result = "";
            for (int i = head; i < tail; i++)
            {
                int index = head + i;
                if (index == maxsize)
                {
                    index = 0;
                }

                result = result + "Caller: " + store[index].CallerName + " , Type: " + store[index].EmergencyType + " , Severity: " + store[index].SeverityLevel + "\n";

            }
            return result;
        }

        // Functions for EX.1B

        public EmergencyCall PeekHighestSeverity()
        {
            if (IsEmpty())
            {
                return null;
            }

            EmergencyCall best = store[head];
            for (int i = 1; i < numitems; i++)
            {
                int index = head + i;
                if(index >= maxsize)
                {
                    index = index - maxsize;
                }
                if (store[index].SeverityLevel > best.SeverityLevel)
                {
                    best = store[index];
                }
            }
            return best;
        }

        public void DequeueFirstKCalls(int k)
        {
            if (IsEmpty () || k <= 0)
            {
                return;
            }

            int available = tail - head;
            if ( k > available)
            {
                k = available;
            }
            for (int i = 0; i < k; i++)
            {
                Dequeue();
            }
        }

        // Functions for EX.1C



        //Free space, use as necessary to address task requirements.







    } // End of class

}
