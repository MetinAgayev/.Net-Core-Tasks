using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Models
{
    public class ProductTag:BaseEntity
    {
        public Nullable<int> TagId { get; set; }
        public Tag Tag { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Product Product { get; set; }
    }
}
