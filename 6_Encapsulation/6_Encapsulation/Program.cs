// 6_encapsulation
// Author: Codeleton011
// Date: 2017. 05. 22

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// C# Encapsulation with public accessor
namespace _6_Encapsulation
{
    class Employee
    {
        // Public access!
        public int age;
        public string name;

        public void displayEmployee()
        {
            Console.WriteLine("Employee Name: {0}", name);
            Console.WriteLine("Employee Age: {0}", age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Declare employee
            Employee emp1 = new Employee();

            // Set values
            emp1.age = 20;
            emp1.name = "Employee1";

            emp1.displayEmployee();

            Console.ReadKey();
        }
    }
}
