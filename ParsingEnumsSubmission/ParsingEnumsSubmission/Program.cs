//===========================================================================================================
//  Nick Rau | 9/12/2024 | Assignment: Parsing Enums Submission
//
//
//===========================================================================================================
using System;
using System.Collections.Generic;


namespace ParsingEnumsSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DaysOfTheWeek myDay;
            string userinput;
            Console.WriteLine("Please enter the day of the week");
            try
            {
                userinput = Console.ReadLine();
                myDay = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userinput);
                Console.WriteLine("Happy " + myDay + "!");
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
    public enum DaysOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
