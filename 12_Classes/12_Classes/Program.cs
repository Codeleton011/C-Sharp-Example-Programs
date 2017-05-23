// 12_Classes
// Author: Codeleton011
// Date: 2017. 05. 23

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Classes
{
    class Employee
    {
        public int age;
        public string name;

        public double salary;

        public void printName()
        {
            Console.WriteLine("{0}", name);
            Console.WriteLine("{0}", age);
            Console.WriteLine("{0} \n", salary);
        }
    }
    // Worker inherits Employee
    class Worker : Employee
    {
        public bool isWorking;

        public bool wIsWorking()
        {
            return isWorking;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.name = "Employee1";
            emp1.age = 20;
            emp1.salary = 3245.234;

            emp1.printName();

            Worker w1 = new Worker();

            w1.name = "Worker1";
            w1.age = 30;
            w1.salary = 2500.123;

            w1.isWorking = true;

            w1.printName();

            Console.WriteLine("Worker is active: {0}", w1.wIsWorking());

            Console.ReadKey();

        }
    }
}
