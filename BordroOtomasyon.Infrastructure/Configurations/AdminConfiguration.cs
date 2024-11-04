
using BordroOtomasyon.Domain.Core.BaseEntityConfiguration;
using BordroOtomasyon.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BordroOtomasyon.Infrastructure.Configurations
{
    public  class AdminConfiguration:AuditableEntityConfiguration<Admin>
    {
        public override void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.Property(a => a.FullName).IsRequired().HasMaxLength(128);
            builder.Property(a=>a.Email).IsRequired().HasMaxLength(128);
            builder.Property(a => a.IdentityId).IsRequired();
            


            base.Configure(builder);
        }
    }
}
