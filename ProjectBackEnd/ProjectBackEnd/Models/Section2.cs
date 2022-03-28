using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ProjectBackEnd.Models
{
    public class Section2
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Procate { get; set; }
        [StringLength(255)]
        public string Price { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(1000)]
        public string Image { get; set; }
        
    }
}
