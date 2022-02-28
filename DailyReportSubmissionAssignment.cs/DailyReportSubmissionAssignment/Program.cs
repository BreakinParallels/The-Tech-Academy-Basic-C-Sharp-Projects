using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //The next two following lines are to be printed upon start of program
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            //Command asks for user's name and receives response
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            //Command asks question to user and receives answer from user
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            //Command asks question that user answers in a form of an integer(numberical value)
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);

            //Command asks question to user where the answer is either true or false
            //A bool is defined as an answer type and quotation are appropiately displayed
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            string help = Console.ReadLine();
            var helpQuestion = Convert.ToBoolean(help);

            //The following commands simply ask questions for the user to input their responses
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string exp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string fback = Console.ReadLine();

            //Command asks question to user where the answer is given by the user in the form of an integer
            //Quotations are also displyed properly using backslashes 
            //Program finishes by displayed ending message
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int studyHrs = Convert.ToInt32(studyHours);
            Console.WriteLine("\"Thank you for all your answers.  An instructor will respond to this shortly.  Have a great day!\" This is the end of the program.");
        }
    }
}
