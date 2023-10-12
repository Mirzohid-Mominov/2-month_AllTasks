using Backend_Model.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend_Model.DataLayer
{
    internal class EfCoreContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseNpgsql
            ("Server = local; Port = 5432; UserName = postgres; Database = postgres; Pasword = postgres");

        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }



    }
}
