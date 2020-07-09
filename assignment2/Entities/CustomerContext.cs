using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace assignment2.Entities
{
    public class CustomerContext:DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-8M9SE7LG;Initial Catalog=test;Integrated Security=True");
        }
    }
}
