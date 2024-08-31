using System.Net;

namespace TraversalCoreProje.ViewModels
{
    public class ResponseViewModel<T>
    {
       
            public T Data { get; set; }

            public List<string> Errors { get; set; }

            public string Error { get; set; }
            public int StatusCode { get; set; }

            public static ResponseViewModel<T> Success(T data, int status)
            {
                return new ResponseViewModel<T> { Data = data, StatusCode = status };
            }
            public static ResponseViewModel<T> Success(int status)
            {
                return new ResponseViewModel<T> { StatusCode = status };
            }
            public static ResponseViewModel<T> Fails(List<string> errors, int status)
            {
                return new ResponseViewModel<T> { Errors = errors, StatusCode = status };
            }

            public static ResponseViewModel<T> Fail(string message, int status)
            {
                return new ResponseViewModel<T> { Error = message, StatusCode = status };
            }

        
    }
}
