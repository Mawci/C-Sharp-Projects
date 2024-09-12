//===========================================================================================================
//  Nick Rau | 9/12/2024 | Assignment: Main Method Submission
//
//
//===========================================================================================================
using System;
using System.Collections.Generic;


namespace MainMethodSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberClass myClass = new NumberClass();

            Console.WriteLine(myClass.mathOperation(75));
            Console.WriteLine(myClass.mathOperation(75.098673621m));
            Console.WriteLine(myClass.mathOperation("300"));
            Console.ReadLine();
        }
    }
}
