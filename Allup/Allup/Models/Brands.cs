﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Models
{
    public class Brands:BaseEntity
    {
        [StringLength(255)]
        public string Name { get; set; }
        public  IEnumerable<Product> Product { get; set; }
    }
}
