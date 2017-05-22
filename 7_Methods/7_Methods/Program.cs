// 7_Methods
// Author: Codeleton011
// Date: 2017. 05. 22

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Methods
{
    class Program
    {
        // Method with return value (INT)
        public int getMin(int a, int b)
        {
            int res;

            if (a < b) // A smaller than B
            {
                res = a;
            } // B smaller than A
            else
            {
                res = b;
            }

            return res;
        }

        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            int res;

            // Call program
            Program p = new Program();

            // p.getMin(5, 10)
            res = p.getMin(a, b);

            Console.WriteLine("Result: {0} \n", res);
          
            // Recursive method call
            int c = 2321;
            int d = 2320;

            Console.WriteLine("Result: {0}", p.getMin(c, d));

            Console.ReadKey();
        }
    }
}
