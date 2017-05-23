// 13_static_polymorphism
// Author: Codeleton011
// Date: 2017. 05. 23

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_static_polymorphism
{
    class Program
    {
        void print(int i)
        {
            Console.WriteLine("Int: {0}\n", i);
        }
        // Overload function
        void print(string i)
        {
            Console.WriteLine("String: {0}", i);
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            p.print(5);
            p.print("Hello World!");

            Console.ReadKey();
        }
    }
}
