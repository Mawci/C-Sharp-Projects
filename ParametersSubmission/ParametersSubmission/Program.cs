//===========================================================================================================
//  Nick Rau | 9/12/2024 | Assignment: Parameters Submission
//
//
//===========================================================================================================
using System;
using System.Collections.Generic;


namespace ParametersSubmission
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>();
            employee.Things.Add("shirt");
            employee.Things.Add("badge");
            employee.Things.Add("phone");
            employee.Things.Add("uniform");

            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int>();
            employee2.Things.Add(77);
            employee2.Things.Add(777);
            employee2.Things.Add(911);
            employee2.Things.Add(343);

            Console.WriteLine("Employee 1 company items include:");
            foreach (string item in employee.Things)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Employee 2's lucky nnumbers are:");
            foreach (int num in employee2.Things)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
