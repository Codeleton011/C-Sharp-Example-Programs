// 5_defining_constant
// Author: Codeleton011
// Date: 2017. 05. 21

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_defining_constant
{
    class Program
    {
        static void Main(string[] args)
        {
            // PI is a constant (can't changeable value)
            const double PI = 3.14; // Note: Rounded   

            double rad;

            Console.WriteLine("Enter radius:");
            rad = Convert.ToDouble(Console.ReadLine());

            double circleArea = PI * rad * rad;

            Console.WriteLine("Radius: {0}, Area: {1}", rad, circleArea);

            Console.ReadKey();
        }
    }
}
