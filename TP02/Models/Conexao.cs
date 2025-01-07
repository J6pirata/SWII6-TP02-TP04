using System.Web;
using System.Linq;
using System.Data.Entity;
using System;

namespace TP02.Models
{
    public class Conexao : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<BL> BLs { get; set; }
        public DbSet<Container> Containers { get; set; }
    }
}
