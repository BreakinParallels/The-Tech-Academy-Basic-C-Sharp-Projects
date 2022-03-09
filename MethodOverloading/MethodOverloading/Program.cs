using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks user to input number to apply function to and converts input to an integer
            Console.WriteLine("Please input an integer to operate on: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            //sets variable for function result applied to integer given by user
            int newNum = mathFunction.myOverload(userNum);
            // returns message with result of function 
            Console.WriteLine("Your integer + 10 is: " + newNum);
            Console.ReadLine();
            //asks user to input number to apply function to and converts input to a float
            Console.WriteLine("Please input a decimal to operate on: ");
            decimal userNumDecimal = Decimal.Parse(Console.ReadLine());
            //sets variable for function result applied to decimal number given by user
            int newNumDecimalInt = mathFunction.myOverload(userNumDecimal);
            // returns message with result of function
            Console.WriteLine("Your decimal multiplied by 5 and converted to an integer is: " + newNumDecimalInt);
            Console.ReadLine();
            //asks user to input number to apply function to and converts a string entered by user to an integer
            Console.WriteLine("Please input a integer to operate on: ");
            int newNumDiv = mathFunction.myOverload(Console.ReadLine());
            // returns message with result of function
            Console.WriteLine("Your integer divided by 10 is: " + newNumDiv);
            Console.ReadLine();
        }
    }
}
