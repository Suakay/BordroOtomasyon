using BordroOtomasyon.Domain.Enums;
using BordroOtomasyon.Domain.Models.Core.BaseEntities;

namespace BordroOtomasyon.Domain.Models.Entites
{
    public class Tediye:AuditableEntity
    {
        public KademeTipi  Kademe { get; set; }  
        public double  Miktar {  get; set; }    



    }
}
