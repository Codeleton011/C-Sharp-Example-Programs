// 3_type_conversion
// Author: Codeleton011
// Date: 2017. 05. 21

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_type_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Explicit type conversion Example
            double PI = 3.14;
            int num;

            num = (int)PI; // Cast double to int
            Console.WriteLine("{0}", num); 

            //Implicit type conversion Example

            double d = 6.28;

            string str;

            str = d.ToString(); // Note: d transformed into string

            Console.WriteLine(str);


            Console.ReadKey();
        }
    }
}
