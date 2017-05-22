// 6_encapsulation_2
// Author: Codeleton011
// Date: 2017. 05. 22

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// C# encapsulation with private accessor
namespace _6_Encapsulation_2
{
    class Employee
    {
        // Private access (Access only class)
        private int age;
        private string name;

        public void userInput()
        {
            Console.WriteLine("Enter employee age:");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter employee name:");
            name = Convert.ToString(Console.ReadLine());
        }

        public void display()
        {
            Console.WriteLine("Employee Name: {0}", name);
            Console.WriteLine("Employee Age: {0}", age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();

            emp1.userInput();
            emp1.display();

            Console.ReadKey();
        }
    }
}
