using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCONSOLE.Model
{
    internal class context:DbContext 
    {
        private const string connectionString = "Server=(localdb)\\mssqllocaldb; Database=Prodcore; Trusted_connection = true;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);  //after installing efc.sql 
        }
        public DbSet<product> Products { get; set; }
        public DbSet<prodbatch> Productbatch { get; set; } 
        public DbSet<student13feb> students { get; set; }
        public DbSet<Standard> standards { get; set; }
    }
}
