using System;
using System.Collections.Generic;


namespace ParametersSubmission
{
    public class Employee<T>
    {
        public List<T> Things { get; set; }
    }
}
