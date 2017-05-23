// 19_Exception_handling
// Author: Codeleton011
// Date: 2017. 05. 23

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 0;
            int c = 0;

            try
            {
                c = a / b; // c = 10 / 0;
            }catch(DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally {
                Console.WriteLine("Result: {0}", c);
            
            }

            Console.ReadKey();

        }
    }
}
