using System;
using System.Collections.Generic;
using System.Text;

namespace DifferentMethodTypes
{
    public class myMethod
    {

        public void myMethodOp(int userNum)
        {
            //displays message to input integer of their choice and program will perform function on,
            //which will display result at the end of the message
            Console.WriteLine("Your number divided by two is: " + (userNum / 2));
        }

        public static int myMethodOp(int userNum, int myNum)
        {
            //displays how newNum is tabulated and will return that result to main program
            int newNum = userNum + myNum;
            return newNum;
        }


    }
}
