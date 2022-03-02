using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //displays intro to user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            //asks user to enter data, data type is stated to program(integer)
            Console.WriteLine("Please enter the package weight:");
            int wt = Convert.ToInt32(Console.ReadLine());

            //Branch statement is created to make sure certain criteria is met so program can determine next action using ("if" and "else" statements)
            if (wt > 50)
            {
                //if criteria is not met, the message below is printed to user, also ending the program
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            //if criteria is met, program will continue asking for more criteria to be met
            else
            {
                //asks user to enter data, data type is stated to program(integer)
                Console.WriteLine("Package width?");
                int width = Convert.ToInt32(Console.ReadLine());

                //asks user to enter data, data type is stated to program(integer)
                Console.WriteLine("Package height?");
                int ht = Convert.ToInt32(Console.ReadLine());

                //asks user to enter data, data type is stated to program(integer)
                Console.WriteLine("Package length?");
                int leng = Convert.ToInt32(Console.ReadLine());

                //program takes data, adds it up to define variable given: sumDimensions
                int sumDimensions = (width + ht + leng); 
                                             
                //takes variable(sumDimensions), compares it in branching statement
                if (sumDimensions > 50)
                    {
                    //if criteria is not met, the message below is printed to user, also ending the program    
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    }
                else
                {                    
                    //if criteria is met, program uses equation stipulated below
                    decimal shippingCost = leng * width * ht * wt / 100;
                    //the total of equation that is variable(shippingCost), is added to the end of WriteLine statement giving the user their total
                    Console.WriteLine("Your estimated total for shipping this package is:$" + shippingCost);
                 
                }

            }

           
            Console.ReadLine();
        }
    }
}
