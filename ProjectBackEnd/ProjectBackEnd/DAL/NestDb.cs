using Microsoft.EntityFrameworkCore;
using ProjectBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEnd.DAL
{
    public class NestDb:DbContext
    {
        public NestDb(DbContextOptions<NestDb> options) : base(options)
        {

        }
       public DbSet<Section1> Section1 { get; set; }
        public DbSet<Section1search> Section1search { get; set; }
        public DbSet<Section2> Section2 { get; set; }
    }
}
