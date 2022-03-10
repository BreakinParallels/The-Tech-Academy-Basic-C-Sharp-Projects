using System;
using System.Collections.Generic;
using System.Text;

namespace ClassSubmissionAssignment285
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            //instantiate myMethod class
            myMethod newMethod = new myMethod();

            //User number is divided by two and is output within the method
            Console.WriteLine("Please input an integer: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            newMethod.myMethodOp(userNum);

            //call on method that has out parameters, display them in messages
            int num1 = 0, num2 = 0;
            newMethod.myMethodOp(out num1, out num2);
            Console.WriteLine("num1 is now " + num1);
            Console.WriteLine("num2 is now " + num2);
            myStatic.myStaticMethod();
            Console.ReadLine();
        }
    }
}
