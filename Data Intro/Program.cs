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
        public static void Main(string[] args)
        {
            int num = 13;
            int num2 = 17;
            int sum = num + num2;
            double d1 = 3.5;
            double d2 = 1.337;
            double sumD = d1 / d2;



            Console.WriteLine(num);
            Console.WriteLine(sum + "\n");
            Console.WriteLine("The sum of " + num + " and " + num2 + " is " + sum + "\n");
            Console.WriteLine("\t" + d1 + " divided by " + d2 + " is " + sumD);
            Console.Read();
        }
    }
}
