// 10_Structures
// Author: Codeleton011
// Date: 2017. 05. 23

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Structures
{
    // Structure of employee
    struct Employee
    {
        public int age; // Age
        public string name; // Name
        public double salary; // Salary
    };

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1;

            // Declare emp1 type of Employee
            emp1.age = 20;
            emp1.name = "Employee1";
            emp1.salary = 3435.345;

            // Print to screen
            Console.WriteLine("Employee name: {0}", emp1.name);
            Console.WriteLine("Employee age: {0}", emp1.age);
            Console.WriteLine("Employee salary: {0}", emp1.salary);

            Console.ReadKey();
        }
    }
}
