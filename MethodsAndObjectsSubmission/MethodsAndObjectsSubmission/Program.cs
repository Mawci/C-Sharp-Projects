//===========================================================================================================
//  Nick Rau | 9/12/2024 | Assignment: Methods and Objects Submission
//
//
//===========================================================================================================
using System;
using System.Collections.Generic;


namespace MethodsAndObjectsSubmission
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee1.SayName();
            Console.ReadLine();
        }
    }
}
