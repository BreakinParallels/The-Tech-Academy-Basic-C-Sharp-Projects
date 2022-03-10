using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment285
{
    public class myMethod
    {
        //creating void method, have the method divide the data passed to it by 2.
        public void myMethodOp(int userNum)
        {
            Console.WriteLine("Your number divided by two is: " + (userNum / 2));
        }
        //Declared a method to be static
        public void  myMethodOp(out int num1, out int num2)
        {
            num1 = 35;
            num2 = 20;
        }

    }
        //declaring a static class
        public static class myStatic
    {
        //Declared a method to be static
        public static void myStaticMethod()
        {
            Console.WriteLine("I am a static method in a static class.");
        }

    }
}
