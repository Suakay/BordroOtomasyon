using BordroOtomasyon.Domain.Utilities.Interfaces;

namespace BordroOtomasyon.Domain.Utilities.Concreates
{
    public class DataResult<T> : Result, IDataResult<T> where T : class
    {
        public T? Data { get; }
        public DataResult(T data ,bool isSucces):base(isSucces)
        {
            Data = data;

        }
        public DataResult(T data,bool isSucces,string message):base(isSucces,message)//Yapılacak işi parçalara bölmek.
        {
            Data = data;
        }

        
    }
}
