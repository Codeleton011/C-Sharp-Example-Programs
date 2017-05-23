// 11_Enums
// Author: Codeleton011
// Date: 2017. 05. 23

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Enums
{
    class Program
    {
        enum Abc {A,B,C,D};

        static void Main(string[] args)
        {
            Console.WriteLine("{0}", Abc.A);
            Console.WriteLine("{0}", Abc.B);
            Console.WriteLine("{0}", Abc.C);
            Console.WriteLine("{0}", Abc.D);

            Console.ReadKey();

        }
    }
}
