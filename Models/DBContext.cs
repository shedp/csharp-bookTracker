using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// 
// {
//     public class ApplicationDbContext : DbContext
//     {
//         public DbSet<Book> Book { get; set; }

//         // protected override void OnConfiguring(DbContextOptionsBuilder options)
//         //     => options.UseSqlite(@"Data Source=/Users/sheenadiep/Desktop/coding/csharp/csharp-intro/db/Book.db");

//     }

// }
namespace csharp_intro.Models
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}