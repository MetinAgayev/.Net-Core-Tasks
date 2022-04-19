using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Models
{
    public class Product : BaseEntity
    {
        [StringLength(255),Required]
        public string Title { get; set; }     
        public double DiscountPrice { get; set; }
        [Required]
        public double Price { get; set; }
        public double ExTax { get; set; }
        [Required]
        public string Code { get; set; }
        public bool Aviability { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public string MainImage { get; set; }
        [Required]
        public string HoverImage { get; set; }
        
        public Nullable<int> CategoryId { get; set; }     
        public Category Category { get; set; }
        public Nullable<int> BrandId { get; set; }
        public Brands Brand { get; set; }
        public IEnumerable<ProductImage> ProductImages { get; set; }
        public IEnumerable<ProductTag> ProductTags { get; set; }
        public IEnumerable<Review> Reviews { get; set; }

    }
}
