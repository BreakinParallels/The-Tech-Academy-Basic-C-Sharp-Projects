using System;

namespace Boolean_Logic_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //prints title
            Console.WriteLine("Insurance Questionaire");

            //asks question to user
            Console.WriteLine("What is your age?");
            //states variable and what type 
            int age = Convert.ToInt32(Console.ReadLine());

            //asks question to user
            Console.WriteLine("Have you ever had a DUI? true or false?");
            
            bool hasDUI = Convert.ToBoolean(Console.ReadLine());

            //asks question to user           
            Console.WriteLine("How many tickets have you had?");
            //states variable and what type
            int tickets = Convert.ToInt32(Console.ReadLine());

            //gives program boolean to determine if qualified or not based on user's answers
            bool qualified;
            if(age > 15 && hasDUI == false && tickets <= 3)
            {
                qualified = true;

            }
            else
            {
                qualified = false;
            }
            //prints quotated to user
            Console.WriteLine("Qualified?");
            //prints answer based on answers using boolean logic above
            Console.WriteLine(qualified);
            
            Console.ReadLine();
        }
    }
}
