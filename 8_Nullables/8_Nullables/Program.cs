// 8_Nullables
// Author: Codeleton011
// Date: 2017. 05. 22

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Nullables
{
    class Program
    {
        // <type>? <name> = null
        static void Main(string[] args)
        {
            int? a = null;
            int? b = 100;
            int? c = new int?();
            int? d = 10;

            bool? bo = new bool?();

            Console.WriteLine("Num1: {0}\n", a);
            Console.WriteLine("Num2: {0}\n", b);
            Console.WriteLine("Num3: {0}\n", c);
            Console.WriteLine("Num4: {0}\n", d);

            Console.WriteLine("Bool1: {0}\n", bo);

            // Null Coalescing Operator

            double? pi = 3.14;
            double? f = null;

            double? n3;

            n3 = f ?? 6.28;
            Console.WriteLine("n3 value: {0}", n3);

            n3 = pi ?? 6.28;
            Console.WriteLine("n3 value: {0}", n3);

            Console.ReadKey();
        }
    }
}
