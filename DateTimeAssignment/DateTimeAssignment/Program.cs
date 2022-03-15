using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determine current time
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);
            Console.WriteLine("Please enter a number: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            //add user specified hours to current time and display it.
            Console.WriteLine("The time " + userNum + " hours from now is: " + dateTime.AddHours(userNum));
            Console.ReadLine();
        }
    }
}
