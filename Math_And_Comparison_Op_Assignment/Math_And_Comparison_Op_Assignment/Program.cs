using System;

namespace Math_And_Comparison_Op_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //prints title ("Anonymous Income Comparison Program") to screen
            Console.WriteLine("Anonymous Income Comparison Program");

            //prints person 1, asks for hr rate, stores user input, asks for hrs per week, stores user input            
            Console.WriteLine("Person 1");
            Console.WriteLine("What is hourly rate for Person 1?");
            string per1Hourlyrate = Console.ReadLine();
            int perHr1 = Convert.ToInt32(per1Hourlyrate);
            Console.WriteLine("Hours worked per week?");
            string per1Hrsworked = Console.ReadLine();
            int p1Hours = Convert.ToInt32(per1Hrsworked);

            //prints person 2, asks for hr rate, stores user input, asks for hrs per week, stores user input
            Console.WriteLine("Person 2");
            Console.WriteLine("What is hourly rate for Person 2?");
            string per2Hourlyrate = Console.ReadLine();
            int perHr2 = Convert.ToInt32(per2Hourlyrate);
            Console.WriteLine("Hours worked per week?");
            string per2Hrsworked = Console.ReadLine();
            int p2Hours = Convert.ToInt32(per2Hrsworked);


            //Tabulates Annual salary of Person 1, prints result
            Console.WriteLine("Annual salary of Person 1");
            int per1Annual = Convert.ToInt32(per1Hourlyrate) * Convert.ToInt32(perHr1) * 52;
            Console.WriteLine(per1Annual);


            //Tabulates Annual salary of Person 2, prints result
            Console.WriteLine("Annual salary of Person 2");
            int per2Annual = Convert.ToInt32(per2Hourlyrate) * Convert.ToInt32(perHr2) * 52;
            Console.WriteLine(per2Annual);


            //prints "Does Person 1 make more money than Person 2?", determines with bool if result is true or false based on user's input
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueOrFalse = per1Annual > per2Annual;
            Console.Write(trueOrFalse);
            Console.ReadLine();
        }
    }
}
