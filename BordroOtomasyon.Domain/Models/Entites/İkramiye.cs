using BordroOtomasyon.Domain.Enums;
using BordroOtomasyon.Domain.Models.Core.BaseEntities;

namespace BordroOtomasyon.Domain.Models.Entites
{
    public class İkramiye:AuditableEntity
    {
        public double Miktar {  get; set; } 
        public KademeTipi Grup {  get; set; } 


    }
}
