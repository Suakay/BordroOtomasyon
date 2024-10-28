using BordroOtomasyon.Domain.Enums;

namespace BordroOtomasyon.Domain.Models.Core.BaseEntities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }=Guid.NewGuid();
        public DateTime? ModifiedDate { get; set; }
        public DateTime CreateDate { get; set; }

        public string CreatedBy { get; set; }
        public string ModeifiedBy { get; set; }
        public Status Status { get; set; }
    }
}
