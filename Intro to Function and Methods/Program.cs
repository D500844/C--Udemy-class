using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_Function_and_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Every method must be called from Main
            // This is indeed HOW methods are called
            // Main runs when the program starts
            WriteSomething();
            WriteSomethingSpecific("I am an arguement and I am called from a method named WriteSomethingSpecific"); // Needs arguement to work
        // The arguement is handed to the method parameter "myText"
        }

        // Access Specificier - The Access Specifier determines the visibility of a variable
        // or a method from another class.

        // Return Type - A method may return a value. The return type is the data type of the
        // value the method returns. If the method is not returning any values, then the return 
        // type is void.

        // Method Name - Method name is a unique indentifier and it is case sensitive. It cannot
        // be the same as any other identifier declared in the class.

        // Parameter List - Enclosed between parentheses, the parameters are used to pass and receive 
        // data from a method. The parameter list refers to the type, order, and number of the parameters
        // of a method. Parameters are optional; that is, a method may contain no parameters.

        // Method Body - This contains the set of instructions needed to complete the required activity.



        // <access modifier> <return type(static)> <Method Name> (parameter1, parameter2){}
        public static void WriteSomething()
        {
            // Method Body
            // This is how Methods are declared or created
            // Methods should usually only do one thing
            Console.WriteLine("I am called from a method named WriteSomething.");
            
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
            Console.Read();
        }
    }
}
