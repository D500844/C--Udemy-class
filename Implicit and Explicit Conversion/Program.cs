using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_and_Explicit_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion
            int num = 12345;
            long bigNum = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;

            // Explicit Conversion
            double myDouble = 13.37;
            int myInt;

            // Cast double to int;
            myInt = (int)myDouble;

            // Type conversion
            string myString = myDouble.ToString(); // "13.37"
            num.ToString();
            myFloat.ToString();
            bool sunIsShining = true;
            sunIsShining.ToString();

            Console.WriteLine(sunIsShining);
            Console.WriteLine(myFloat);
            Console.WriteLine(myInt);
            Console.Read();
            
        }
    }
}
