using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //Create another class called Employee and have it inherit from the Person class
    public class Employee : Person
    {
        public int id { get; set; }
        //overriding SayName method from Person class
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
