using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class AfolouContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            object p = optionsBuilder.UseSqlServer(@"Data Source=192.168.0.197;Initial Catalog=Chapelaria;Persist Security Info=True;User ID=chapeu;Password=1324");
        }
        public DbSet<Afolou> Afolous { get; set; }
    }
}
