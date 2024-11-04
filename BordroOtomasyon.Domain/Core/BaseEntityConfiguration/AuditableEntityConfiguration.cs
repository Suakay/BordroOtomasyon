using BordroOtomasyon.Domain.Core.BaseEntities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BordroOtomasyon.Domain.Core.BaseEntityConfiguration
{
    public class AuditableEntityConfiguration<TEntity> : BaseEntityConfiguration<TEntity> where TEntity : AuditableEntity
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(x => x.CreatedDate).IsRequired(true);
            builder.Property(x => x.ModifiedDate).IsRequired(false);
            builder.Property(x => x.DeletedDate).IsRequired(false);
            builder.Property(x => x.CreatedBy).IsRequired(true);
            builder.Property(x => x.ModifiedBy).IsRequired(false);
            builder.Property(x => x.DeletedBy).IsRequired(false);

            base.Configure(builder);
        }
    }
}
