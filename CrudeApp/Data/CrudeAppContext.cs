using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudeApp.Models;

namespace CrudeApp.Data
{
    public class CrudeAppContext : DbContext
    {
        public CrudeAppContext (DbContextOptions<CrudeAppContext> options)
            : base(options)
        {
        }

        public DbSet<CrudeApp.Models.User> User { get; set; } = default!;
    }
}
