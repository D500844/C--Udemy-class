using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes_String_Methods_and_Variables
{
    class Program
    {
        /*static void Main(string[] args)
        {

            // these are string data types assigned to named variables
            string myname = "Dave";
            string message = "My name is " + myname;

            // New variable of string type with method using lower case letters.
            string lowerCaseMessage = message.ToLower();

            // String method example ToUpper(); changes all letters to uppercase
            string capsMessage = message.ToUpper();

            Console.WriteLine(lowerCaseMessage);
            Console.WriteLine(capsMessage);
            Console.WriteLine(message);
            Console.Read();
        }*/

        static void Main(string[] args)
        {
            Console.Write("Enter a string and press enter: ");
            string readInput = Console.ReadLine();
            Console.WriteLine("You have entered {0}", readInput);

            Console.Write("Enter a string and press enter: ");
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII value is {0}:", asciiValue);
            Console.ReadKey();
        }
    }
}
