using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjectBackEnd.Models
{
    public class Section1search
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        public int Section1Id { get; set; }
        public Section1 Section1 { get; set; }
    }
}
