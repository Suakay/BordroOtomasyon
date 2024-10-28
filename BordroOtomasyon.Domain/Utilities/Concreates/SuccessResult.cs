namespace BordroOtomasyon.Domain.Utilities.Concreates
{
    public class SuccessResult:Result
    {
        public SuccessResult():base(true)
        {
            
        }
        public SuccessResult(string message):base(true,message) { }

       
    }
}
