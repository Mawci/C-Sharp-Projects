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
        List<string> names = new List<string>() { "Nick", "Jack", "Matt", "Mark", "John", "Paul" };
        List<string> numbers= new List<string>() { "one", "two", "three", "four", "five", "six",
        "seven", "eight", "nine", "ten", "one", "two", "three", "three", "two", "two", "two"};
        List<string> colors = new List<string>() { "red", "blue", "white", "purple", "orange", "red", "blue" };
        Dictionary<string, bool> hasAppeared = new Dictionary<string, bool>();
        hasAppeared.Add("red", false);
        hasAppeared.Add("blue", false);
        hasAppeared.Add("white", false);
        hasAppeared.Add("purple", false);
        hasAppeared.Add("orange", false);

        string[] stringArray = { "number", "letter", "word", "sentence", "character", "paragraph" };

        string input;

        int count = 0;

        //================= Part One ==================
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
        foreach (string color in colors)
        {
            if (hasAppeared[color] == false)
            {
                Console.WriteLine(color + " is in the list and appearing for the first time.");
                hasAppeared[color] = true;
            }
            else
            {
                Console.WriteLine(color + " is in the list BUT this has already appeared in out list previously!");
            }
        }

        Console.ReadLine();
    }
}

