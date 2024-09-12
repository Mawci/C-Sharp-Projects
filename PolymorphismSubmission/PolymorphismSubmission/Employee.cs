using System;
using System.Collections.Generic;


namespace PolymorphismSubmission
{
    internal class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine($@"Hello, my name is {firstName}");
        }

        public void Quit()
        {
            Console.WriteLine($@"{firstName} {lastName} has just voiced desire to quit!");
        }
    }
}
