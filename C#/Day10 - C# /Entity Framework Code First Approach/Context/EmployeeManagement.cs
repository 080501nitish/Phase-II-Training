using EFCF.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCF.Context
{
    internal class EmployeeManagement : DbContext
    {
        public DbSet<Dept> Depts { get; set; }
        public DbSet<Emp> Emps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source = DESKTOP-HCQDF97\\SQLEXPRESS; database = EmployeeManagement; integrated security=SSPI; TrustServerCertificate=True;");
                
            
            
        }
    }
}
