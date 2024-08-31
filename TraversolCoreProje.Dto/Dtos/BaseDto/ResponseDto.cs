using System.Net;

namespace TraversolCoreProje.Dto.Dtos.BaseDto
{
    public record ResponseDto<T>
    {
        public T Data { get; set; }

        public List<string> Errors { get; set; }

        public string Error { get; set; }
        public int StatusCode { get; set; }

        public static ResponseDto<T> Success(T data, int status)
        {
            return new ResponseDto<T> { Data = data, StatusCode = status };
        }
        public static ResponseDto<T> Success( int status)
        {
            return new ResponseDto<T> {StatusCode = status };
        }
        public static ResponseDto<T> Fails(List<string> errors, int status)
        {
            return new ResponseDto<T> { Errors = errors, StatusCode = status };
        }

        public static ResponseDto<T> Fail(string message, int status)
        {
            return new ResponseDto<T> { Error = message, StatusCode = status };
        }

    }
}
