using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StarlightTech.Web.Models;

namespace StarlightTech.Web.Data
{
    public class StarlightTechWebContext : DbContext
    {
        public StarlightTechWebContext (DbContextOptions<StarlightTechWebContext> options)
            : base(options)
        {
        }

        public DbSet<StarlightTech.Web.Models.Department> Department { get; set; } = default!;

        public DbSet<StarlightTech.Web.Models.Employee> Employee { get; set; } = default!;
    }
}
