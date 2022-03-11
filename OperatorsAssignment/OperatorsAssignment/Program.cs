using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person1 = new Employee() { Id = 1 };
            Employee person2 = new Employee() { Id = 2 };
            //Overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property
            Console.WriteLine(person1 == person2);
            Console.ReadLine();
        }
    }
}
