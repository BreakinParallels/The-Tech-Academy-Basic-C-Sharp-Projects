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

            //A list of strings that has at least two identical strings in the list.
            List<string> doubleNames = new List<string>() { "Bill", "Bob", "Becky", "Barb", "Bob" };
            //Ask the user to input text to search for in the list.
            Console.WriteLine("Please write a name: Bill, Bob, Becky, Barb");
            string myNameDouble = Console.ReadLine();

            //Create a loop that iterates through the list and then displays the indices of the items matching the user - selected text.

            int index2 = 0;
            foreach (string name in doubleNames)
            {
                if (name == myNameDouble)
                {
                    Console.WriteLine(index2);
                }
                else
                {
                    //Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.
                    if (index2 >= 4)
                    {
                        Console.WriteLine("Name is not on the list.");
                        break;
                    }
                }
                index2++;

            }



            
            //Created a list of strings that has at least two identical strings in the list
            List<int> examScores = new List<int>() { 98, 99, 12, 74, 23, 99, 98, 45, 74, 82, 77, 98, 85 };
            List<int> sameScores = new List<int>();
            //Create a foreach loop that evaluates each item in the list 
            foreach (int score in examScores)
            {
                Console.WriteLine(score);
            //displays a message showing the string and whether or not it has already appeared in the list.
                if (sameScores.Contains(score))
                {
                    Console.WriteLine("This number has repeated.");
                }
                else
                {
                    Console.WriteLine("This number has NOT repeated");
                }
                sameScores.Add(score);
            }
            
            Console.ReadLine();
        




        }

            

        }
    }

