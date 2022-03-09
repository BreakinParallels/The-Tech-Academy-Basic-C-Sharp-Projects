using System;

namespace MethodSubAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //displays message asking for user input, takes input, converts it into an integer, assigns variable to integer
            Console.WriteLine("Please input an integer: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            //asks user for 2nd number, lets them know they need not enter anything for the second number
            //converts user's input into an integer
            Console.WriteLine("Please input a second integer (optional): ");
            bool userNum2IsValid = int.TryParse(Console.ReadLine(), out int userNum2);
            //gives parameter based off user's input and what to do if user decides not to enter second integer
            int result = 0;
            if (userNum2IsValid)
            {
                result = myMath.AddInts(userNum, userNum2);
            }
            else
            {
                result = myMath.AddInts(userNum);
            }

            //displays message and adds user's result based on user's and parameters given above
            Console.WriteLine("Your result is: " + result);
            Console.ReadLine();
        }
    }
}