using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExceptionExamples
{
    public class MyZeroDivideException : Exception //exception added to get expections
    {
        private string advice;

        public MyZeroDivideException(string message, string advice) : base(message)
        {
            this.advice = advice;
        }
        public string ShowAdvice()
        {
            return advice;
        }
    }
}