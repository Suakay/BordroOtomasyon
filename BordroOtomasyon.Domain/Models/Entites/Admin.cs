using BordroOtomasyon.Domain.Models.Core.BaseEntities;

namespace BordroOtomasyon.Domain.Models.Entites
{
    public class Admin:AuditableEntity
    {
        public string FullName {  get; set; }   
        public string Email {  get; set; }  
        public string IdentityId {  get; set; } 

    }
}
