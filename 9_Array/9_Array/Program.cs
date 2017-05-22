// 9_Array
// Author: Codeleton011
// Date: 2017. 05. 22

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a new array
            int[] values = new int[5] { 1, 2, 3, 4, 5 };

            // Accessing the arrays
            for(int i = 0; i < values.Length; i++)
            {
                Console.WriteLine("values[{0}] = {1}", i, values[i]);
            }

            Console.ReadKey();
        }
    }
}
