using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BordroOtomasyon.Domain.Utilities.Concretes
{
    public class ErrorResult : Result
    {
        public ErrorResult() : base(false) { } //Issucces özelliğini false olarak tanımlar.
        public ErrorResult(string message) : base(false, message) { }
    }//newlediğim yerde yanlış işte bi de success result yazıcaz.
}
