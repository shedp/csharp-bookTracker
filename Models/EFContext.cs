using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_intro.Models
{
    public class DemoContext : DbContext
    {
        public DbSet<Category> Category { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"/Users/sheenadiep/Desktop/coding/csharp/csharp-intro/db/category.db");
    }

}