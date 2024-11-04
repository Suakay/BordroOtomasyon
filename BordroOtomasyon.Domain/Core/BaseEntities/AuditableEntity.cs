using BordroOtomasyon.Domain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BordroOtomasyon.Domain.Core.BaseEntities
{
    public class AuditableEntity:BaseEntity,IDeletableEntity
    {
        public DateTime? DeletedDate { get; set; }

        public string? DeletedBy { get; set; }

    }

    
}
