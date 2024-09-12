//===========================================================================================================
//  Nick Rau | 9/11/2024 | Assignment: Calling Methods Submission
//
//
//===========================================================================================================
using System;
using System.Collections.Generic;


namespace CallingMethodsSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass tempClass = new MyClass();
            int userInput;

            Console.WriteLine("What number would you like to alter?");
            userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Calling the addFive function...");
            Console.WriteLine(tempClass.addFive(userInput));

            Console.WriteLine("Calling the doubleNum function...");
            Console.WriteLine(tempClass.doubleNum(userInput));

            Console.WriteLine("Calling the IncrementNum function...");
            Console.WriteLine(tempClass.incrementNum(userInput));

            Console.ReadLine();
        }
    }
}
