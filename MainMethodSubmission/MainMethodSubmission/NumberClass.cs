using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    public class NumberClass
    {
        public int mathOperation(int number)
        {
            number = number * number;
            return number;
        }

        public int mathOperation(decimal number)
        {
            number = number * 2;
            return (int)number;
        }

        public int mathOperation(string number)
        {
            return Convert.ToInt32(number) + 5;
        }
    }
}
