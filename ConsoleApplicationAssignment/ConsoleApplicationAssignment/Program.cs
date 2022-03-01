using System;

namespace ConsoleApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //Code takes input from the user, multiplies it by 50, then prints the result to the console
            Console.WriteLine("Please enter a number.");
            int myNum = int.Parse(Console.ReadLine());
            Console.WriteLine(myNum * 50);

            //Code takes an input from the user, adds 25 to it, then prints the result to the console
            Console.WriteLine("Please enter a number.");
            int myNum2 = int.Parse(Console.ReadLine());
            Console.WriteLine(myNum2 + 25);

            //Code takes an input from the user, divides it by 12.5, then prints the result to the console
            Console.WriteLine("Please enter a number.");
            int myNum3 = int.Parse(Console.ReadLine());
            Console.WriteLine(myNum3 / 12.5);

            //Code takes an input from the user, checks if it is greater than 50, then prints the true/false result to the console
            Console.WriteLine("Please enter a number.");
            int myNum4 = int.Parse(Console.ReadLine());
            bool trueOrFalse = myNum4 > 50;
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();

            //Code takes an input from the user, divides it by 7, then prints the remainder to the console
            Console.WriteLine("Please enter a number.");
            int myNum5 = int.Parse(Console.ReadLine());
            Console.WriteLine(myNum5 % 7);
            Console.ReadLine();

        }
    }
}
