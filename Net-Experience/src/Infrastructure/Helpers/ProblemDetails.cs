using System;

namespace Net.Experience.Common.Helpers
{
    public class ProblemDetails
    {
        public string Detail { get; set; }

        public ProblemDetails(string detail) 
        {
            Detail = detail;
        }
    }
}
