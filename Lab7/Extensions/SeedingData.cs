using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab7.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab7.Extensions
{
    public static class SeedingData
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<TaiKhoan>().HasData(new TaiKhoan(){Id = 1,Username = "admin",Password = "admin"});
        }
    }
}
