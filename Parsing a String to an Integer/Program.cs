using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_a_String_to_an_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "15";
            string mySecondString = "13";
            // Parsing Strings into numbers
            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);

            int result = num2 + num1;

            Console.WriteLine(result);
            Console.Read();
        }
    }
}
