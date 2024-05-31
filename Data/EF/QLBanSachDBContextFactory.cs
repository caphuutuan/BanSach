using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanSach.Models;

namespace Data.EF
{
    public class QLBanSachDBContextFactory : IDesignTimeDbContextFactory<QLBanSachDBContext>
    {
        public QLBanSachDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<QLBanSachDBContext>();
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-F656NNQ\\HUUTUAN;Initial Catalog=QLBanSach;Integrated Security=True;Trust Server Certificate=True");

            return new QLBanSachDBContext(optionsBuilder.Options);
        }
    }
}