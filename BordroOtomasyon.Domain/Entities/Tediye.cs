using BordroOtomasyon.Domain.Core.BaseEntities;
using BordroOtomasyon.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BordroOtomasyon.Domain.Entities
{
    public class Tediye:AuditableEntity
    {
        public KademeTipi Kademe { get; set; }
        public double Miktar { get; set; }
    }
}
