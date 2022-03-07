using System;
using System.Collections.Generic;

namespace ConsoleApp6PartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //setting the data type and variable with corresponding index in array
            string[] colors = { "red", "blue", "black", "yellow", "green", "purple" };
            
            //program will ask user question, their choice will be converted to an integer which will correspond to position in index
            Console.WriteLine("Please choose a color: red, blue, black, yellow, green, or purple.");
            string colorChoice = Console.ReadLine();

            // Will add user input to string array
            for (int oldArray = 0; oldArray < colors.Length; oldArray++)
            {
                colors[oldArray] = colors[oldArray] + colorChoice;
            }

            //Will display new string array with user input
            for (int updatedArray = 0; updatedArray < colors.Length; updatedArray++)
            {
                Console.WriteLine("Your new color string:" + colors[updatedArray]);

            }

            bool condition = true;

            /* Infinite loop code
            while(condition)
            {
                Console.WriteLine("This is a broken loop.");
            }
            */

            //Fixed infite loop code
            while (condition)
            {
                Console.WriteLine("This is a fixed inifite loop.");
                condition = false;
            }

            //A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
            for (int oldArray = 0; oldArray < colors.Length; oldArray++)
            {
                colors[oldArray] = colors[oldArray] + colorChoice;
            }

            //A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
            for (int oldArray = 0; oldArray <= 5; oldArray++)
            {
                colors[oldArray] = colors[oldArray] + colorChoice;
            }

            //test display for the above two loops
            /*for (int updatedArray = 0; updatedArray < colors.Length; updatedArray++)
            {
                Console.WriteLine("Your new color string:" + colors[updatedArray]);

            }
            */

            //A list of strings where each item in the list is unique
            List<string> names = new List<string>() { "Bill", "Bob", "Becky", "Barb" };
            //Ask the user to input text to search for in the list.
            Console.WriteLine("Please write a name: Bill, Bob, Becky, Barb");
            string myName = Console.ReadLine();

            //A loop that iterates through the list and then displays the index of the list that contains matching text on the screen.           
            int index = 0;
            foreach (string name in names)
            {
                if (name == myName)
                {
                    Console.WriteLine(index);
                    //Add code to the loop that stops it from executing once a match has been found.
                    break;
                }
                index++;

                //Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.
                if (index > 3)
                {   
                    Console.WriteLine("Name is not on the list.");
                }
             }

            Console.ReadLine();

        }
    }
}
