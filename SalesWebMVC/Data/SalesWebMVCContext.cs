using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Models;

namespace SalesWebMVC.Models
{
    public class SalesWebMVCContext : DbContext //classe responsavel por integrar com o Entity
    {
        public SalesWebMVCContext(DbContextOptions<SalesWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; } // a classe precisa ser um DBset para ser identificada pelo entity
        public DbSet<SalesRecord> SalesRecords { get; set; }

    }
}
