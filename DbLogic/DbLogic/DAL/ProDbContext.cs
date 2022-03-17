using DbLogic.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbLogic.DAL
{
    public class ProDbContext:DbContext
    {
        public ProDbContext(DbContextOptions<ProDbContext> options) : base(options) { }

            public DbSet<Product> products { get; set; }
            public DbSet<Category> categories { get; set; }

    }
}
