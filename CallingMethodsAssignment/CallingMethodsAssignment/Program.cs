using System;

namespace CallingMethodsAssignment
{
   
    class Program
    {
        static void Main(string[] args)
        {
            //asks the user what number they want to do the math operations on
            Console.WriteLine("Please enter an integer to perfrom math operations on: ");
            int userNum = Convert.ToInt32(Console.ReadLine());

            //Calls each method in turn, passing the user's input into each method
            int newNumAdd = mathFunction.addInt(userNum);
            int newNumSub = mathFunction.subInt(userNum);
            int newNumMult = mathFunction.multInt(userNum);

            //Displays user's input results for each method
            Console.WriteLine("Your number plus 10 is: " + newNumAdd);
            Console.WriteLine("Your number subtracted by 5 is: " + newNumSub);
            Console.WriteLine("Your number multiplied by 10 is: " + newNumMult);
            Console.ReadLine();
        }
    }
}
