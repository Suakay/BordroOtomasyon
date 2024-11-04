using BordroOtomasyon.Domain.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BordroOtomasyon.Domain.Utilities.Concretes
{
    public class DataResult<T> : Result, IDataResult<T> where T : class
    {
        public T? Data { get; }

        public DataResult(T data, bool isSuccess) : base(isSuccess)
        {
            Data = data;
        }
        //tek parametreli olanı çalıştır base ifadesi
        public DataResult(T data, bool isSuccess, string message) : base(isSuccess, message)
        {
            Data = data;
        }
        //iki parametreli olanı çalıştır resulttaki ctorlardan demek base ifadesi
    }
}
