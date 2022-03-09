using System;
using System.Collections.Generic;
using System.Text;

namespace DifferentMethodTypes
{
    public class myMethod
    {

        public void myMethodOp(int userNum, int userNum2)
        {
            //displays message to input integer of their choice and program will perform function on,
            //which will display result at the end of the message
            userNum += 7;
            Console.WriteLine("Your second input was: " + userNum2);
        }
    }
}
