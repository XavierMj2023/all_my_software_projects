using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
	public class APIDbContext : DbContext
	{
		public APIDbContext(DbContextOptions<APIDbContext> options) : base(options)
		{
		}
		public DbSet<Department> Departments { get; set; }
		public DbSet<EmployeeAngular> Employees { get; set; }
	}
}
