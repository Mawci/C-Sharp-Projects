using System;
using System.Collections.Generic;


namespace AbstractClassSubmission
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine($@"Hello, my name is {firstName}");
        }
    }
}
