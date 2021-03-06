using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string here: ");
            // Read first input string.
            string input = Console.ReadLine();

            Console.Write("Enter a Character to search: ");
            // Read the character input to search
            char searchInput = Console.ReadLine()[0];
            // Gets the Index of the character from the string.
            int searchIndex = input.IndexOf(searchInput);
            // Prints the Index as a search result on console.
            Console.WriteLine("Index of character {0} in string is {1}", searchInput, searchIndex);

            Console.Write("Enter first name: ");
            // Read the first name
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            // Read the last name
            string lastName = Console.ReadLine();

            // Concatinate the firstName and lastName variable and assign that to a fullName variable.
            string fullName = string.Concat(firstName, " ", lastName);
            // Prints the full name on the console.
            Console.WriteLine("Your full name is {0} and that's the bottom line", fullName);

            Console.ReadKey();

        }
    }
}
 