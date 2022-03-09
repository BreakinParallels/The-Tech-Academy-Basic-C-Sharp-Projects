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

        //Declare a class to be static
        public static int myMethodOp(int userNum, int myNum)
        {
            int newNum = userNum + myNum;
            return newNum;
        }


    }
}
