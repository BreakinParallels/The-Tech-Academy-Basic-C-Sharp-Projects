using System;

namespace DifferentMethodTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate myMethod class
            myMethod newMethod = new myMethod();

            //User number is divided by two and is output within the method
            newMethod.myMethodOp(5, 10);
            //now calling in the method and passing parameters by name
            newMethod.myMethodOp(userNum: 5 , userNum2: 6);
        }
    }
}