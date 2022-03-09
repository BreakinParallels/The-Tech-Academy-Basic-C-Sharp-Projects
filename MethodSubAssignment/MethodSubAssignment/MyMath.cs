using System;
using System.Collections.Generic;
using System.Text;

namespace MethodSubAssignment
{
    class myMath
    {
        //sets parameter stating AddInts will be user's input for userNum and a default value of 0 if user does not give input for 2nd int
        public static int AddInts(int userNum, int userNum2 = 0)
        {
            //creates variable from user's input for userNum + userNum2
            int newUserNum = userNum + userNum2;
            //returns value back to main program
            return newUserNum;
        }
    }
}
