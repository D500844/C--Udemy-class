using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt that takes input whole numbers from user
            Console.Write("Enter the number:");

            // Converts input to an integer
            int number;

            // Convert whatever user has entered to an int32
            // This limits size of number to int32/~2b
            number = Convert.ToInt32(Console.ReadLine());

            // The amount of divisors
            int divisors = 0;

            // For loop 

            // Starts with i = 1, then checks if i is less than or equal to user number
            // Checks is user number is smaller than i, then increases i incrimentally 
            for (int i=1; i <= number; i++)
            {
                // Checks if modulo of user number is equal to 0
                // If the user number divided by i leaves a remainder of 0- cont.
                // Then we will know we need to increase divisors 
                if (number % i == 0)
                {
                    // Incrimentally increases the divisors 
                    divisors++;

                    // Process repeats until 
                }
            }

            if (divisors == 2)
            {
                Console.WriteLine("The entered number is a Prime Number");
            }
            else
            {
                Console.WriteLine("The entered number is not a Prime Number");
            }
            Console.ReadLine();

        }
    }
}
