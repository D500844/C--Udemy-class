using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Intro
{
    //Variable example with default value
    public class Lecture
    {
        int age = 13;

        public static void Main(string[] args)
        {
            int age = 15;
            Console.WriteLine(age); // Output will be 15
            Console.Read();
        }
    }
}
