using BordroOtomasyon.Domain.Interfaces;

namespace BordroOtomasyon.Domain.Models.Core.BaseEntities
{
    public  class AuditableEntity:BaseEntity,   IDeletableEntity
    {
        
        public DateTime DeletedDate { get; set; }
        public string? DeletedBy {  get; set; }
        DateTime? IDeletableEntity.DeletedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
