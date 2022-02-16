using System;
using System.Globalization;

namespace Net.Experience.Application.Exceptions
{
    public class BusinessRulesException : Exception
    {
        public BusinessRulesException() : base()
        {
        }

        public BusinessRulesException(string message) : base(message)
        {
        }

        public BusinessRulesException(string message, params object [] args) : base(String.Format(CultureInfo.CurrentCulture, message,args))
        {
        }
    }
}
