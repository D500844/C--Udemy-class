using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Console_Methods
{
    // Class names use ClientActivity use PascalCase
    class BigThing
    {
        // Method names like BigBooty also use PascalCase
        // Arguements/Method Arguements like firstTendies use camelCasing
        static void Main(string[] bigolItties)
        {
            // Local variables like itemBalls use PascalCase
            // User control like ultimateFaperoth use camelCase
            // Don't use abbreviations
            // Don't use numbers at the start of names
            
            /*Correct
             * string myName;
             * int lastNum;
             * bool isSaved;
             * 
             * Avoid
             * String MyName;
             * Int32 LastNum;
             * Bool 3IsSaved;
             */ 
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hello Dave.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("C# is bae");

            Console.Read();
        }
    }
}
