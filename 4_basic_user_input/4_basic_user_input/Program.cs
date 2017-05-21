// 4_basic_user_input
// Author: Codeleton011
// Date: 2017. 05. 21

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_basic_user_input
{
    class Program
    {
        static void Main(string[] args)
        {
            string test;
            int d;

            // Basic user input
            Console.WriteLine("Enter a value:");
            test = Console.ReadLine();

            Console.WriteLine("\n" + test);

            // Basic user input 
            // Using System.Convert

            d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(d);

            Console.ReadKey();
        }
    }
}
