using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Objects_Submission
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //calls the superclass method SayName() on the Employee object
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
