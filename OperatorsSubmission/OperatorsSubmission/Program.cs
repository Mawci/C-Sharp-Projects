//===========================================================================================================
//  Nick Rau | 9/12/2024 | Assignment: Overloading Operators Submission
//
//
//===========================================================================================================
using System;
using System.Collections.Generic;


namespace OperatorsSubmission
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { Id = 2345 };
            Employee employee2 = new Employee() { Id = 2435 };
            Employee employee3 = new Employee() { Id = 2345 };

            Console.WriteLine("Comparing employee1 and 2. Are they the same?");
            Console.WriteLine(employee2 == employee1);
            Console.WriteLine("Comparing employee1 and 3. Are they the same?");
            Console.WriteLine(employee3 == employee1);
            Console.ReadLine();
        }
    }
}
