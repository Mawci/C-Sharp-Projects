using System;
using System.Collections.Generic;
using System.Web;


namespace ClassSubmission
{
    public class Numbers
    {
        public void numberMethod(int number)
        {
            number /= 2;
            Console.WriteLine(number);
        }

        public void numberMethod2(int number, out int result, out int resultSquared)
        {
            result = number + 10;
            resultSquared = result * result;
        }

        //Overloaded method
        public void numberMethod(int number, string name)
        {
            number /= 2;
            Console.WriteLine(number + " is the quotient of dividing by 2. Good job " + name);
        }
    }
}
