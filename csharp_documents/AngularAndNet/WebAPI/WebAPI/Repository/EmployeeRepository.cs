using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Repository
{
	public class EmployeeRepository : IEmployeeRepository
	{
		private readonly APIDbContext _appDBContext;
        public EmployeeRepository(APIDbContext context)
        {
			_appDBContext = context ?? throw new ArgumentNullException(nameof(context));
		}
        public bool DeleteEmployee(int ID)
		{
			bool result = false;
			var department = _appDBContext.Employees.Find(ID);
			if (department != null)
			{
				_appDBContext.Entry(department).State = EntityState.Deleted;
				_appDBContext.SaveChanges();
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		public async Task<EmployeeAngular> GetEmployeeByID(int ID)
		{
			return await _appDBContext.Employees.FindAsync(ID);
		}

		public async Task<IEnumerable<EmployeeAngular>> GetEmployees()
		{
			return await _appDBContext.Employees.ToListAsync();
		}

		public async Task<EmployeeAngular> InsertEmployee(EmployeeAngular objEmployee)
		{
			_appDBContext.Employees.Add(objEmployee);
			await _appDBContext.SaveChangesAsync();
			return objEmployee;
		}

		public async Task<EmployeeAngular> UpdateEmployee(EmployeeAngular objEmployee)
		{
			_appDBContext.Entry(objEmployee).State = EntityState.Modified;
			await _appDBContext.SaveChangesAsync();
			return objEmployee;
		}
	}
}
