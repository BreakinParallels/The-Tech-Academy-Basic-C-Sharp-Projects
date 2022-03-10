using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolymorphismAssignment;

namespace PolymorphismAssignment
{
    //Create another class called Employee and have it inherit from the Person class
    public class Employee : Person, IQuittable
    {
        public int id { get; set; }

        public void Quit()
        {
            throw new NotImplementedException();
        }

        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
