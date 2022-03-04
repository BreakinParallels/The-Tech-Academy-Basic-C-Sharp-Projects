using System;
using System.Collections.Generic;


class Program
{
    static void Main()

    {
        //setting the data type and variable with corresponding index in array
        string[] colors = {"red", "blue", "black", "yellow", "green", "purple"};
        //program will ask user question, their choice will be converted to an integer which will correspond to position in index
        Console.WriteLine("Please choose a number 0 - 5.");
        int colorChoice = Convert.ToInt32(Console.ReadLine());
        //tells program if number chosen is greater than 5, to pick again with details to do so in response printed
        if (colorChoice > 5)
            Console.WriteLine("Please choose a number 0 - 5.");
        //tells program to print user's choice based number within array chosen as text
        else
            Console.WriteLine(colors[colorChoice]);
            Console.ReadLine();


        //setting the data type and variable with corresponding index in array
        int[] numbers = { 5, 2, 10, 200, 500, 600, 2300 };
        //program will ask user question, their choice will be converted to an integer which will correspond to position in index
        Console.WriteLine("Choose a number from 0-6 display the integer.");
        int numChoice = Convert.ToInt32(Console.ReadLine());
        //tells program if number chosen is greater than 6, to pick again. if choice is satisfactory, the result within array will be printed
        if (numChoice > 6)
            Console.WriteLine("That number is not in the index.");
        else
            Console.WriteLine(numbers[numChoice]);
            Console.ReadLine();

        //establishes a list and the string within
        List<string> stringList = new List<string>();
        stringList.Add("Tanjiro");
        stringList.Add("Ichigo");
        stringList.Add("Koichi");
        stringList.Add("Bruno");
        //ask user to pick number that will represent a certain string within list
        Console.WriteLine("Pick a number and the corresponding name will pop up:");
        //establishes variable for string and also a variable for the answer by user that is converted to integer 
        string fname = Console.ReadLine();
        int name = Convert.ToInt32(fname);

        //tells program if number chosen is greater than 3, to print certain response . if choice is satisfactory, the result(string) within list will be printed
        if (name > 3)
            Console.WriteLine("That name is not in the index.");
        else
            Console.WriteLine(stringList[name]);

        Console.ReadLine();

    }
}







        


    
    

