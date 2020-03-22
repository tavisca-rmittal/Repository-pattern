using System;
using RepositoryPattern.Models;
using Microsoft.EntityFrameworkCore;


namespace RepositoryPattern
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
           : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}
