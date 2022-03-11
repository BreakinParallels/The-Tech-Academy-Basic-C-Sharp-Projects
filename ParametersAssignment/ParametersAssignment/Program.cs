using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate an Employee object with type “string” as its generic parameter. Assign a list of strings as the property value of Things.
            Employee<string> stuff = new Employee<string>();
            stuff.Things = new List<string> { "Book", "Car", "Ball", "Pool" };
            //Instantiate an Employee object with type “int” as its generic parameter. Assign a list of integers as the property value of Things.
            Employee<int> otherStuff = new Employee<int>();
            otherStuff.Things = new List<int> { 1, 4, 25, 66, 100 };

            //Create a loop that prints all of the Things to the Console.
            for (int i = 0; i < stuff.Things.Count; i++)
            {
                Console.WriteLine(stuff.Things[i]);
            }
            for (int i = 0; i < stuff.Things.Count; i++)
            {
                Console.WriteLine(otherStuff.Things[i]);
            }

            //    employee person1 = new employee();
            //    employee person2 = new employee();

            //    person1.firstname = "sample";
            //    person1.lastname = "student";
            //    person1.id = convert.toint32("1234");
            //    person1.sayname();

            //    person2.firstname = "bill";
            //    person2.lastname = "north";
            //    person2.id = convert.toint32("1234");
            //    person2.sayname();

            //    if (person1 == person2)
            //        console.writeline("the two employee's have the same id.");
            //    else
            //        console.writeline("the two employee's have different id's");


            //    //use polymorphism to create an object of type iquittable and call the quit() method on it.
            //    person1.quit(person1);
            //    person2.quit(person2);
        }
    }
}