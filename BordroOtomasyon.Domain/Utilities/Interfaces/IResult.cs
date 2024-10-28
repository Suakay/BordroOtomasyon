namespace BordroOtomasyon.Domain.Utilities.Interfaces
{
    public interface IResult
    {
        public bool IsSuccess { get;  }
        public string Message { get; }
    }
}
