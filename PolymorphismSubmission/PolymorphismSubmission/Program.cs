//===========================================================================================================
//  Nick Rau | 9/12/2024 | Assignment: Polymorphism Submission
//
//
//===========================================================================================================
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


namespace PolymorphismSubmission
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            
            employee.Quit();
            Console.ReadLine();
        }

    }
}
