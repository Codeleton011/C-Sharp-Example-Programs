#define PI
// 18_Preprocessors
// Author: Codeleton011
// Date: 2017. 05. 23

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _18_Preprocessors
{
    class Program
    {
        static void Main(string[] args)
        {
          #if (PI)
            Console.WriteLine("PI defined!");
          #else
            Console.WriteLine("PI is not defined!");
            
          #endif

          Console.ReadKey();
        }
    }
}