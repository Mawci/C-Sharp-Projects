//===========================================================================================================
//  Nick Rau | 9/11/2024 | Assignment: Console App Sumbission
//
//
//===========================================================================================================
using System;


namespace Console_App_Submission
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a positive number to count down");
            int number = Convert.ToInt32(Console.ReadLine());
            
            while(number != 0)
            {
                number--;
                Console.WriteLine(number);  
            }

            Console.WriteLine("That was a while loop. Now guess a number bewtween 1 and 10");
            number = Convert.ToInt32(Console.ReadLine());
            bool guessedCorrectly = number == 7;

            do
            {
                if (number == 7)
                {
                    Console.WriteLine("You have guessed correctly! Congrats, this was completed with a do-while loop");
                    guessedCorrectly = true;
                }
                else
                {
                    Console.WriteLine("That is not correct! Guess again.");
                    number = Convert.ToInt32(Console.ReadLine());
                }
            }
            while (!guessedCorrectly);

            Console.ReadLine();
        }
    }
}
