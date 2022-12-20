using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerRegistration.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerRegistration.Persistence
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
        {}

        public DbSet<Customer> Customers { get; set; }
    }
}