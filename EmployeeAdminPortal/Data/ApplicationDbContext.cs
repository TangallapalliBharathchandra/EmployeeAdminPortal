using Microsoft.EntityFrameworkCore;
using EmployeeAdminPortal.Models.Entities;

namespace EmployeeAdminPortal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

       public DbSet<Employee> Employee { get; set; }
        public object Employees { get; internal set; }
    }
}
