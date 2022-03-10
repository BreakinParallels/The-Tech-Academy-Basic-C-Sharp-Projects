using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Objects_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiates new employee and set their name
            Employee person1 = new Employee() { FirstName = "Sample", LastName = "Student" };
            //Call the inherited person method to display the Employee name
            person1.SayName();
        }
    }
}
