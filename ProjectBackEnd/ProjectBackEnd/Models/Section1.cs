using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace ProjectBackEnd.Models
{
    public class Section1
    {
        public int Id { get; set; }
        [StringLength(1000)]
        public string Image { get; set; }
        public IEnumerable<Section1search> Section1Searches { get; set; }

    }
}
