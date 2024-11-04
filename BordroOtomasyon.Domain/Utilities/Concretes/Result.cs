using BordroOtomasyon.Domain.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BordroOtomasyon.Domain.Utilities.Concretes
{
    public class Result : IResult
    {
        public bool IsSucces { get; set; }
        public string Message { get; set; }

        public Result()
        {
            IsSucces = false;
            Message = string.Empty;
        }
        public Result(bool isSucces)
        {
            IsSucces = isSucces;
        }

        public Result(bool isSucces, string message) : this(isSucces)
        {
            Message = message;
        }
    }
}
