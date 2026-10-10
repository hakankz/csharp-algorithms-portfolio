using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx3
{
    class ComplexityFunctions
    {
        //Big O calculation for Assessed Exercise 3A

        //Hints : 
        //Use lecture materials from Week 6B to aid with calculations.

        //See ExampleQuestion() to see a suggested format for showing your
        // working out and final answer, both of which must be shown with correct
        // answers for full marks.


        public void ExampleQuestion()
        {
            //F.C
            Console.WriteLine("Enter a number 1:");          // 1
            int num1 = Int32.Parse(Console.ReadLine());      // 1

            Console.WriteLine("Enter a number 2:");          // 1
            int num2 = Int32.Parse(Console.ReadLine());      // 1

            for (int i = 1; i <= num2; i++)                  // n + 1
            {
                Console.WriteLine(num1.ToString() + " X "
                    + i.ToString() + " = " + (num1 * i));   // n
            }

            Console.WriteLine("End of program...");         // 1

            Console.ReadLine();                             // 1


            //Working out

            // 7 + 2n - All F.Cs added together
            // 2n     - Constants removed
            // n      - Coefficients removed
            // O(n)   - Final answer
        }

        public void Algorithm1()
        {
            int n = Int32.Parse(Console.ReadLine());  // 1
            List<int> numbers = new List<int>();      // 1
            for (int i = 0; i < n; i++)               // n + 1
            {
                numbers.Add(i * 2);                   // n
            }
            int total = 0;                            // 1
            for (int i = 0; i < n; i++)               // n + 1
            {
                for (int j = i; j < n; j++)           // n^2 
                {
                    if (numbers[j] % 3 == 0)          // n^2
                    total += numbers[j];              // n^2
                }
            }
            Console.WriteLine("Total: " + total);     // 1

            //Working out

            // 6 + 3n +3n^2 - All F.Cs added together
            // 3n + 3n^2    - Constants removed
            // n^2      - Coefficients removed
            // O(n^2)    -Final answer
        }

        public void Algorithm2()
        {

            int n = Int32.Parse(Console.ReadLine()); //1
            int primeCount = 0;                      //1

            for (int i = 2; i <= n; i++)             // n + 1
            {
                bool isPrime = true;                //n
                int j = 2;                          //n
                while (j * j <= i)                 // n√n
                {
                    if (i % j == 0)                // n√n

                    {
                        isPrime = false;           // n√n
                        break;                     // n√n
                    }
                    j++;                         // n√n
                }
                if (isPrime)                     // n
                    primeCount++;               // n

            }
            Console.WriteLine("Number of primes up to " + n + ": " + primeCount); //1

            //Working out

            // 4 + 5n +5n√n - All F.Cs added together
            // 5n +5n√n    - Constants removed
            // n√n      - Coefficients removed
            // O(n√n)    -Final answer
        }
    }
}
