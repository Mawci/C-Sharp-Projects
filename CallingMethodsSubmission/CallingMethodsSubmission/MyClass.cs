using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsSubmission
{
    public class MyClass
    {
        public int addFive(int num)
        {
            return num += 5;
        }

        public int doubleNum(int num)
        {
            return num *= 2;
        }

        public int incrementNum(int num)
        {
            return ++num;
        }
    }
}
