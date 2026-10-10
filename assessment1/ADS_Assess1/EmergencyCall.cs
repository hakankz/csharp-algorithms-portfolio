using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS_Assess1
{
    //EmergencyCall class implementation for use with EmergencyQueue structure

    //Please finish the following implementation.
    //Do not delete the current function definitions, just replace the exceptions with the required functionality.

    //See material from 'C# Classes' in week 2 to aid with implementation.
    internal class EmergencyCall : IComparable
    {
        private string callername;
        private string emergencytype;
        private int severitylevel;

        public EmergencyCall(string callername, string emergencytype, int severitylevel)
        {
            CallerName = callername;
            EmergencyType = emergencytype;
            SeverityLevel = severitylevel;
        }

        public string CallerName
        {
            get { return callername; }
            set { if(value !=  "")
                    callername = value;
            else
            Console.WriteLine("Caller name cannot be empty.");

            }
        }

        public string EmergencyType
        {
            get { return emergencytype; }
            set { if (value == "Fire" || value == "Medical" || value == "Police")
                    emergencytype = value;
                else
                    Console.WriteLine("Invalid emergency type. Please enter Fire, Medical, or Police.");

            }
        }

        public int SeverityLevel
        {
            get { return severitylevel; }
            set {if (value >= 1 && value <= 5)
                    severitylevel = value;
            else
                    Console.WriteLine("Severity level must be between 1 and 5.");
            }
        }

        public int CompareTo(object obj)
        {
            EmergencyCall other = (EmergencyCall)obj;
            return SeverityLevel.CompareTo(other.SeverityLevel);
        }

        public override string ToString()
        {
            return "Caller: " + CallerName +
                   ", Type: " + EmergencyType +
                   ", Severity: " + SeverityLevel;
        }



    }

}
