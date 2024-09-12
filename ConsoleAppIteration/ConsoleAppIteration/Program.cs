//===========================================================================================================
//  Nick Rau | 9/11/2024 | Assignment: Console App Iteration 6-parts
//
//
//===========================================================================================================
using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        string input;
        int count = 0;

        //================= Part One ==================
        string[] stringArray = { "number", "letter", "word", "sentence", "character", "paragraph" };
        Console.WriteLine("Please enter some text");
        input = Console.ReadLine();

        for (int i = 0; i < stringArray.Length; i++)
        {
            stringArray[i] += input;
        }

        for(int i = 0;i < stringArray.Length;i++)
        {
            Console.WriteLine(stringArray[i]);
        }

        while(count < stringArray.Length)
        {
            Console.WriteLine(stringArray[count] + " : " + count);
            count++;
        }

        //================= Part Two && Three ==================
        count = 0;
        while (count <= stringArray.Length - 1)
        {
            Console.WriteLine(stringArray[count] + " : " + count);
            count++;
        }

        //================= Part Four ==================
        List<string> names = new List<string>() { "Nick", "Jack", "Matt", "Mark", "John", "Paul" };
        Console.WriteLine("We have a list of names, please enter a name to search for it (try Nick, or Paul)");
        input = Console.ReadLine();
        
        if(names.Contains(input))
        {
            foreach (string name in names)
            {
                if (name == input)
                {
                    Console.WriteLine(name + " is at the index of " + names.IndexOf(name));
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("You entered a name that is not within the list!");
        }

        //================= Part Five ==================
        List<string> numbers = new List<string>() { "one", "two", "three", "four", "five", "six",
        "seven", "eight", "nine", "ten", "one", "two", "three", "three", "two", "two", "two"};
        Console.WriteLine("We now have a list of written numbers. Please spell the number you wish to search for.");
        input = Console.ReadLine();

        count = 0;
        if(numbers.Contains(input))
        {
            foreach (string number in numbers)
            {
                if (number == input)
                {
                    Console.WriteLine(number + " is found at index " + count);
                }
                count++;
            }
        }
        else
        {
            Console.WriteLine("You entered a number that was not spelled correctly or it is not between one and ten");
        }

        //================= Part Six ==================
        List<string> colors = new List<string>() { "red", "blue", "white", "purple", "orange", "red", "blue" };
        List<string> duplicateColors = new List<string>();
        foreach (string color in colors)
        {
            if(duplicateColors.Contains(color))
            {
                Console.WriteLine(color + " already exists in the list. Not adding");
            }
            else
            {
                Console.WriteLine("Adding " + color + " to the list");
                duplicateColors.Add(color);
            }
        }

        Console.ReadLine();
    }
}

