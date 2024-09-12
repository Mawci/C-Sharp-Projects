//===========================================================================================================
//  Nick Rau | 9/12/2024 | Assignment: Method Class Submission
//
//
//===========================================================================================================
using System;
using System.Collections.Generic;


namespace MethodClassSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numbers myClass = new Numbers();

            myClass.mathNumbers(15, 343);
            myClass.mathNumbers(num1: 20, num2: 777);
            Console.ReadLine();
        }
    }
}
