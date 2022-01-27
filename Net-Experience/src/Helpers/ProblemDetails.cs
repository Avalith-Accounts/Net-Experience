using System;

namespace Net.Experience.Common.Helpers
{
    public class ProblemDetails
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public ErrorCode Status { get; set; }
        public string Detail { get; set; }
        public Guid Tracer { get; set; }

        public static ProblemDetails GetProblemDetails(string type, string title, ErrorCode status, string detail)
        {
            return new ProblemDetails()
            {
                Type = type,
                Title = title,
                Status = status,
                Detail = detail,
                Tracer = Guid.NewGuid()
            };
        }
    }
}
