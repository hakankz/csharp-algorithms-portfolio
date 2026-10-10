using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx2
{
    //Film class implementation for Assessed Exercise 2

    class VideoGame : IComparable
    {
        private string title;
        private string developer;
        private int releaseyear;
        private readonly bool validate = true;

        public VideoGame()
        {
            title = "";
            developer = "";
            releaseyear = 0;
        }

        public VideoGame(string title, string developer, int releaseyear, bool validate = true)
        {
            this.validate = validate;

            Title = title;
            Developer = developer;
            Releaseyear = releaseyear;

        }

        public string Title
        {
            get { return title; }
            set { if (value != "")
                    title = value;
            else
                    Console.WriteLine("Title cannot be empty.");
            }
        }

        public string Developer
        {
            get { return developer; }
            set { if (value != "")
                    developer = value;
                else if (validate)
                    Console.WriteLine("Developer cannot be empty.");
            }
        }

        public int Releaseyear
        {
            get { return releaseyear; }
            set { if (value >= 1970 && value <= 2025)
                    releaseyear = value;
            else if (validate)
                    Console.WriteLine("Release year must be between 1970 and 2025.");
            }
        }

        public int CompareTo(object obj)
        {
            VideoGame other = (VideoGame)obj;
            return Title.CompareTo(other.Title);
        }
        public override string ToString()
        {
            return "Title: " + Title +
                   ", Developer: " + Developer +
                   ", Release Year: " + Releaseyear;
        }


    }// End of class
}
