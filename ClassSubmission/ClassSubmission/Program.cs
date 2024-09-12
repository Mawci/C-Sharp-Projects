//===========================================================================================================
//  Nick Rau | 9/12/2024 | Assignment: Class Submission
//
//
//===========================================================================================================
using System;
using System.Collections.Generic;


namespace ClassSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numbers myClass = new Numbers();
            int userNum;
            Console.WriteLine("Please enter a number to be passed to a function.");
            userNum = Convert.ToInt32(Console.ReadLine());
            myClass.numberMethod(userNum);

            //Method with output parameters
            int numAdded, numSquared;
            Console.WriteLine("Please entere another number.");
            userNum = Convert.ToInt32(Console.ReadLine());
            myClass.numberMethod2(userNum, out numAdded, out numSquared);
            Console.WriteLine(userNum + " + 10 = " + numAdded + ". The squared equals " + numSquared);

            //Overload a method
            myClass.numberMethod(2, "Nick");

            //Static Class
            MyStaticClass.printHello(); 
            Console.ReadLine();
        }
    }
}
