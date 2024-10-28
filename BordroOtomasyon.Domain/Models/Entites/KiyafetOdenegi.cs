using BordroOtomasyon.Domain.Enums;
using BordroOtomasyon.Domain.Models.Core.BaseEntities;

namespace BordroOtomasyon.Domain.Models.Entites
{
    public class KiyafetOdenegi:AuditableEntity
    {
        public double OdenenMiktar {  get; set; } 
        public KademeTipi Kademe {  get; set; } 


    }
}
