using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LiqourCentre.Models;

namespace LiqourCentre.Data
{
    public class LiqourCentreContext : DbContext
    {
        public LiqourCentreContext (DbContextOptions<LiqourCentreContext> options)
            : base(options)
        {
        }

        public DbSet<LiqourCentre.Models.Product> Product { get; set; }

        public DbSet<LiqourCentre.Models.Brand> Brand { get; set; }

        public DbSet<LiqourCentre.Models.Wine> Wine { get; set; }
    }
}
