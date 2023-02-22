using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using coremvc.Models;

namespace coremvc.Data
{
    public class coremvcContext : DbContext
    {
        public coremvcContext (DbContextOptions<coremvcContext> options)
            : base(options)
        {
        }

        public DbSet<coremvc.Models.Customer> Customer { get; set; } = default!;
    }
}
