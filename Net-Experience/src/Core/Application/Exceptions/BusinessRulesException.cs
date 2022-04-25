using System;
using System.Collections.Generic;

namespace Net.Experience.Application.Exceptions
{
    public class BusinessRulesException : Exception
    {
        public IEnumerable<string> ErrorMessage { get; set; }
        public BusinessRulesException() : base()
        {
        }

        public BusinessRulesException(string message) : base(message)
        {
        }

        public BusinessRulesException(string message, IEnumerable<string> errorMessage) : base(message)
        {
            ErrorMessage = errorMessage;
        }
    }
}
