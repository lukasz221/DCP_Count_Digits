using System;

namespace Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // #1
            int x = 321321;

            Console.WriteLine(x.ToString().Length);

            // #2
            
            Console.WriteLine(countDigit(x));

        }

        static int countDigit(long n)
        {
            if (n / 10 == 0)
                return 1;
            return 1 + countDigit(n / 10);
        }
    }
}

// Write a function that takes a natural number as input and returns the number of digits the input has.
// Constraint: don't use any loops.