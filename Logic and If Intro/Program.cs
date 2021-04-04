using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_and_If_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature at # wise?: ");
            string tempUserInput = Console.ReadLine();
            int temperature = int.Parse(tempUserInput);


            if(temperature < 10)
            {
                Console.WriteLine("Take the coat");
            }

            if(temperature == 10)
            {
                Console.WriteLine("It's 10 degrees C*");
            }

            if(temperature > 10)
            {
                Console.WriteLine("Cozy & warm!");
            }
            Console.Read();
        }
    }
}
