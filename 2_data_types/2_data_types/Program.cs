// 2_data_types
// Author: Codeleton011
// Date: 2017. 05. 21

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            float foo = 20.3F;
            const double PI = 3.14; // Const means -> Not changeable
            string hello = "Hello";
            bool used = true;
            //....

            // {0} like %type in C
            Console.WriteLine("Number: {0}", num);
            Console.WriteLine("Float: {0}", foo);
            Console.WriteLine("Double: {0}", PI);
            Console.WriteLine("String: {0}", hello);
            Console.WriteLine("Boolean: {0}", used);

            Console.ReadKey();
        }
    }
}
