using System.Collections.Generic;

namespace Net.Experience.Common.Helpers
{
    public class Response<T>
    {
        public bool Succeeded { get; set; }
        public string Message { get; set; }

        public List<string> Error { get; set; }
        public T Data { get; set; }

        public Response(T data, string message = null) 
        {
            Succeeded = true;
            Message = message;
            Data = data;
        }

        public Response(string message) 
        {
            Succeeded = false;
            Message = message;
        }
    }
}
