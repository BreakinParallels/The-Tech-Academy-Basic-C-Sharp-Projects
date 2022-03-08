using System;
using System.Collections.Generic;

namespace StringsAndIntegersSub
{
    class Program
    {
        static void Main(string[] args)
        {
            //Created a list of integers
            List<int> numbs = new List<int> { 11, 44, 30, 60 };

            /*Created a try/catch block, make the program print a message to the display to let you know the program 
            has emerged from the try/catch block and continued on with program execution. Displays the error message to the screen*/
            try
            {
                Console.WriteLine("Input a number to divide some numbers by");
                int input = Convert.ToInt32(Console.ReadLine());
                //instructions to program on what to do with proper input given by user
                foreach (int numb in numbs)
                {
                    Console.WriteLine(numb + "divided by " + input + " equals " + numb / input);
                }
            }
            //if user types a incorrect data types such as letters/text, program will return error message below 
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
                return;
            }
            //if user types a zero, program will return error message below
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}

