using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wrap the above statement in a try/catch block and have it print
            //"Please enter an actual day of the week.” to the console if an error occurs
            try
            {
                //Prompt the user to enter the current day of the week
                Console.WriteLine("Please enter the day of the week: ");
                //Assign the value to a variable of that enum data type you just created
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine(), true);
                Console.WriteLine("The date is: {0}", day.ToString());
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }
        }
        //Create an enum for the days of the week
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }

}
