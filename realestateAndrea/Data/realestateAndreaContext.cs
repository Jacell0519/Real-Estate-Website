using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using realestateAndrea.Model;

namespace realestateAndrea.Data
{
    public class realestateAndreaContext : DbContext
    {
        public realestateAndreaContext (DbContextOptions<realestateAndreaContext> options)
            : base(options)
        {
        }

        public DbSet<realestateAndrea.Model.User> User { get; set; } = default!;
    }
}
