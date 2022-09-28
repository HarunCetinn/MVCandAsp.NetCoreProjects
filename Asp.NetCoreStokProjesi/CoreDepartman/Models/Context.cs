using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDepartman.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-40IUGLP; database = corepersonel; integrated security=true;");
        }

        public DbSet<Departmanlar> departmanlars { get; set; }
        public DbSet<Personel> personels { get; set; }
        public DbSet<Admin> admins { get; set; }
    }
}
