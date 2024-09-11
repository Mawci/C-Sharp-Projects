//===========================================================================================================
//  Nick Rau | 9/11/2024 | Assignment: Arrays Sumbission
//
//
//===========================================================================================================
using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        int userIndex;
        string[] nameArray = { "Nick", "Aubrey", "Bob", "Sarah", "Genie", "Walter" };
        int[] integerArray = { 100, 495, 092384, 2763, 7, 777, 343 };
        List<string> items = new List<string>();
        items.Add("table");
        items.Add("chair");
        items.Add("carpet");
        items.Add("sofa");
        items.Add("cabinet");


        //Get input to display sting Array
        Console.WriteLine("We have an array of names. Please enter a value between 0 and 5 to retrieve" +
            " a name!");
        userIndex = Convert.ToInt32(Console.ReadLine());
        if ((userIndex > nameArray.Length-1) || userIndex < 0)
        {
            Console.WriteLine("That index does not exist.");
        }
        else
        {
            Console.WriteLine("The name that you have chosen is " + nameArray[userIndex]);
        }
        

        //Get input to display integer array
        Console.WriteLine("We have an array of integers. Please enter a value between 0 and 6 to retrieve" +
            " one!");
        userIndex = Convert.ToInt32(Console.ReadLine());
        if ((userIndex > integerArray.Length - 1) || userIndex < 0)
        {
            Console.WriteLine("That index does not exist.");
        }
        else
        {
            Console.WriteLine("The value and the position " + userIndex + " is " + integerArray[userIndex]);
        }

        //Get index to diplay the items List
        Console.WriteLine("We have a list of items. Please enter a value between 0 and 4 to retrieve" +
            " one!");
        userIndex = Convert.ToInt32(Console.ReadLine());
        if ((userIndex > items.Count - 1) || userIndex < 0)
        {
            Console.WriteLine("That index does not exist.");
        }
        else
        {
            Console.WriteLine(items[userIndex]);
        }

        Console.ReadLine();
    }
}

