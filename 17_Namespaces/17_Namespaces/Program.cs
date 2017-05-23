// 17_Namespaces
// Author: Codeleton011
// Date: 2017. 05. 23

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// using test namespace
using test;

namespace test
{
    class abc
    {
        public void print()
        {
            Console.WriteLine("Hello!");
        }
    }
}

namespace _17_Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Access abc class within test namespace
            //Not required test.abc a = new test.abc();
            
            // Allowed if the using test declared
            abc a = new abc();

            a.print();

            Console.ReadKey();
        }
    }
}
