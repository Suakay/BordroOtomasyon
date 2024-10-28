using BordroOtomasyon.Domain.BaseEntityConfigurations;
using BordroOtomasyon.Domain.Models.Core.BaseEntities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Buffers.Text;

namespace BordroOtomasyon.Domain.BaseEntityConfiguration
{
    public class AuditableEntityConfiguration<TEntity>:BaseEntityConfiguration<TEntity> where TEntity : AuditableEntity
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(x => x.CreateDate).IsRequired(true);
            builder.Property(x => x.ModifiedDate).IsRequired(false);
            builder.Property(x => x.DeletedDate).IsRequired(false);
            builder.Property(x => x.CreatedBy).IsRequired(true);
            builder.Property(x => x.ModeifiedBy).IsRequired(false);
            builder.Property(x => x.DeletedBy).IsRequired(false);
            base.Configure(builder);
        }
    }
}
