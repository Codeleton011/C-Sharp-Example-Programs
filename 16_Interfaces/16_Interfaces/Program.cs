// 16_Interfaces
// Author: Codeleton011
// Date: 2017. 05. 23

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Interfaces
{
    public interface Shape
    {
        void display();
        int getWide();
    }
    
    // Interfaces can be inherited with class
    public class A : Shape
    {
        private int a;
        private int b;

        // Constructor of the A class
        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void display()
        {
            Console.WriteLine("A: {0} \nB: {0}", a, b);
        }

        public int getWide()
        {
            return a * b;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            A shape = new A(10,10);

            shape.display();
            Console.WriteLine("Shape Wide: {0}", shape.getWide());

            Console.ReadKey();
        }
    }
}
