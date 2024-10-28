


namespace BordroOtomasyon.Domain.Utilities.Concreates
{
    public class Result : IResult
    {
        
        public bool IsSuccess { get; set; }    
        public string Message { get; set; }
        public Result()
        {
            IsSuccess = false;
            Message=string.Empty;   

        }

        public Result(bool isSuccess)
        {
            IsSuccess = isSuccess;
            
        }
        public Result(bool isSucces,string message) : this(isSucces)
        {
            Message = message;

        }

        public Task ExecuteAsync(HttpContext httpContext)
        {
            throw new NotImplementedException();
        }
       
    }
}
