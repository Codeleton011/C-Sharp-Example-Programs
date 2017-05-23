// 15_Operator_overloading
// Author: Codeleton011
// Date: 2017. 05. 23

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Operator_overloading
{
    class Cube
    {

        private int a;

        public int getSurface()
        {
            return 6 * a * a;
        }

        public int getVolume()
        {
            return a * a * a;
        }

        public void setA(int i)
        {
            a = i;
        }
        // Overload operator with operator+
        public static Cube operator+ (Cube b)
        {
            Cube c1 = new Cube();

            c1.a = c1.a + b.a;

            return c1;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Cube c = new Cube();
            Cube d = new Cube();

            c.setA(5);
            d.setA(10);

            Console.WriteLine("Cube Surface: {0}  \n", c.getSurface());
            Console.WriteLine("Cube Volume: {0} \n", c.getVolume());

            Console.ReadKey();
        }
    }
}
