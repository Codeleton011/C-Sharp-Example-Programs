// 14_dynamic_polymorphism
// Author: Codeleton011
// Date: 2017. 05. 23

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_dynamic_polymorphism
{
    abstract class Shape
    {
        public abstract int area();
    }

    class Rectangle : Shape
    {
        private int length;
        private int width;

        public Rectangle(int a = 0, int b = 0)
        {
            length = a;
            width = b;
        }
        public override int area()
        {
            return (width * length);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10, 10);
            double a = rect.area();
            Console.WriteLine("Area: {0}", a);

            Console.ReadKey();
        }
    }
}
