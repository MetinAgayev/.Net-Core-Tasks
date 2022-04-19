using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Models
{
    public class Category:BaseEntity
    {
        [StringLength(255),Required]
        public string Name { get; set; }
        public Category ParentId { get; set; }
        [StringLength(1000), Required]
        public string Image { get; set; }
    }
}
