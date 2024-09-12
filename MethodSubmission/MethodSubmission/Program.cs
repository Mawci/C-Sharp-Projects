using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numbers myClass = new Numbers();
            int num1, num2;
            var num3 ="";


            Console.WriteLine("Please enter two numbers to be added together. If you chose to only enter " +
                "one number, then the number will be incremented.");
            num1 = Convert.ToInt32(Console.ReadLine());
            num3 = Console.ReadLine();

            if (num3 == "")
            {
                Console.WriteLine(myClass.addNumbers(num1));
            }
            else
            {
                num2 = Convert.ToInt32(num3);
                Console.WriteLine(myClass.addNumbers(num1, num2));
            }
            
            Console.ReadLine();
        }
    }
}
