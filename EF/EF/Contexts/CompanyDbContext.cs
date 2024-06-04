using EF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EF.Contexts
{
    public class CompanyDbContext : DbContext
    {
     

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder.UseSqlServer("Server=.;Database=myDataBase;Trusted_Connection=True;");

        public DbSet<Employee> Employees { get; set; }
    }




}
