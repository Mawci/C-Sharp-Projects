//===========================================================================================================
//  Nick Rau | 9/11/2024 | Assignment: Console App Try/Catch Submission
//
//
//===========================================================================================================
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 25, 40, 10, 39, 49, 64, 30 };
        int divBy;

        Console.WriteLine("Please enter a number that will be used to divide by");
        
        try
        {
            divBy = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i] / divBy);
            }
            Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine("The program just emerged from a try/catch block and continued on with execution");
            Console.WriteLine(e.Message);
        }

        Console.ReadLine();
    }
}

