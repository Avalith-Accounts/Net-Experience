using Microsoft.AspNetCore.Http;
using Net.Experience.Application.Exceptions;
using Net.Experience.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace Net_Experience.Middleware
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch(Exception ex) 
            {
                var response = context.Response;
                response.ContentType = "application/json";

                var responseModel = new Response<string>() { Succeeded = false, Message = ex?.Message,  Error = new List<ProblemDetails>() };                

                switch (ex) 
                {
                    case BusinessRulesException e:
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        responseModel.Status  = HttpStatusCode.BadRequest;
                        break;
                    case NotFoundException e:
                        response.StatusCode = (int)HttpStatusCode.NotFound;
                        responseModel.Status = HttpStatusCode.NotFound;
                        responseModel.Error.Add(new ProblemDetails(e.ErrorMessage));
                        break;
                }

                var result = JsonSerializer.Serialize(responseModel);
              
                await response.WriteAsync(result);
            }

        }
    }
}
