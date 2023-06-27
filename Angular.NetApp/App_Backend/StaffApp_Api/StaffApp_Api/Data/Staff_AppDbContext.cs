using Microsoft.EntityFrameworkCore;
using StaffApp_Api.Models;

namespace StaffApp_Api.Data
{
    public class Staff_AppDbContext : DbContext
    {
        public Staff_AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
