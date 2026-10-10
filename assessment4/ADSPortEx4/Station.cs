using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx4
{
    class Station : IComparable
    {
        private string name;
        private int passengerCapacity;
        public Station(string name, int passengerCapacity)
        {
            Name = name;
            PassengerCapacity = passengerCapacity;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value != "")
                    name = value;
                else
                    Console.WriteLine("Name cannot be empty.");

            }
        }

        public int PassengerCapacity
        {
            get { return passengerCapacity; }
            set
            {
                if (value < 0 )
                    Console.WriteLine("Passenger capacity cannot be under zero.");
                else
                    passengerCapacity=value;

            }
        }

        public int CompareTo(object obj)
        {
            Station other = (Station)obj;
            return Name.CompareTo(other.Name);
        }
        public override string ToString()
        {
            return Name;
        }

    }
}
