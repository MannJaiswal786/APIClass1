using APIClass1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIClass1.Data
{
    public class EFCoreDbContext:DbContext
    {
        //1. Connection String
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=MSI\SQLEXPRESS; Database=APIClass1; Trusted_Connection=True");
        }

        //2. DbSets
        public DbSet<Quote> Quote { get; set; }
        public DbSet<Categorys> Categorys { get; set; }


    }
}
