using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab7.Configurations;
using Lab7.Extensions;
using Lab7.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab7.Context
{
    public class PQVContext:DbContext
    {
        public PQVContext(DbContextOptions<PQVContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TaiKhoanCfg());
        }

        public DbSet<TaiKhoan> TaiKhoan { get; set; }
    }
}
