using BordroOtomasyon.Domain.Enums;

namespace BordroOtomasyon.Domain.Core.BaseEntities
{
    public class BaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid Id { get; set; } = Guid.NewGuid();
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Status Status { get; set; }
    }
}