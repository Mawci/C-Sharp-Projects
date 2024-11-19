//===========================================================================================================
//  Nick Rau | 9/13/2024 | Assignment: DateTime Submission
//
//
//===========================================================================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine("Please enter a number.");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The time in {0} hours will be {1}", num, DateTime.Now.AddHours((num)));
            Console.ReadLine();
        }
    }
}
