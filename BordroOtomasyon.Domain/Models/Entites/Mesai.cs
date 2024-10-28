using BordroOtomasyon.Domain.Enums;
using BordroOtomasyon.Domain.Models.Core.BaseEntities;

namespace BordroOtomasyon.Domain.Models.Entites
{
    public class Mesai:AuditableEntity
    {
        public int  Saat {  get; set; }  

        public double SaatlikUcret {  get; set; }   

        public KademeTipi Kademe {  get; set; } 
        
    }
}
