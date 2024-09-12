//===========================================================================================================
//  Nick Rau | 9/12/2024 | Assignment: Abstract Class Submission
//
//
//===========================================================================================================
using System;
using System.Collections.Generic;


namespace AbstractClassSubmission
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            employee.SayName();
            Console.ReadLine();
        }
    }
}
