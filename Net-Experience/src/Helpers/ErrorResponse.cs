using Microsoft.AspNetCore.Mvc;

namespace Net.Experience.Common.Helpers
{
    public static class ErrorResponse
    {
        public static IActionResult BuildErrorResponse(string message, string endpoint, string module, ErrorCode errorCode)

        {
            var problemDetails = ProblemDetails
                                        .GetProblemDetails(endpoint, module,
                                         errorCode, message);

            return new ObjectResult(problemDetails)
            {
                ContentTypes = { "application/problem+json" },
                StatusCode = (int)errorCode,
            };
        }
    }
}
