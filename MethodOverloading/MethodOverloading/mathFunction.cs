using System;

namespace MethodOverloading
{   
    class mathFunction
    {
        //this method adds 10 to user's integer input
        public static int myOverload(int num)
        {
            int myNum = num;
            int myNumAdd = myNum + 10;
            return myNumAdd;
        }

        //this method multiplies 5 to user's float/decimal input
        public static int myOverload(float num)
        {
            int myNum = Convert.ToInt32(num);
            int myNumMult = myNum * 5;
            return myNumMult;
        }

        //this method divides user's string input by 10 
        public static int myOverload(string num)
        {
            int myNum = Convert.ToInt32(num);
            int myNumDiv = myNum / 10;
            return myNumDiv;
        }
    }
    
}
