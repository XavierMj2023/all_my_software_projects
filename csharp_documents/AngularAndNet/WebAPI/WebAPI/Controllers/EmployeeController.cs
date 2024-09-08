using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Repository;

namespace WebAPI.Controllers
{
	public class EmployeeController : Controller
	{
		private readonly IEmployeeRepository _employee;
		private readonly IDepartmentRepository _department;

		private readonly IWebHostEnvironment _env;
		public EmployeeController(IEmployeeRepository employee , IDepartmentRepository department
								, IWebHostEnvironment env)
		{
			_employee = employee ?? throw new ArgumentNullException(nameof(employee));
			_department = department ?? throw new ArgumentNullException(nameof(department));
			_env = env;
		}
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		[Route("GetEmployee")]
		public async Task<IActionResult> GetAllEmployeeNames()
		{
			return Ok(await _employee.GetEmployees());
		}
		[HttpGet]
		[Route("GetEmployeeByID/{Id}")]
		public async Task<IActionResult> GetEmpByID(int Id)
		{
			return Ok(await _employee.GetEmployeeByID(Id));
		}
		[HttpPost]
		[Route("AddEmployee")]
		public async Task<IActionResult> Post(EmployeeAngular emp)
		{
			var result = await _employee.InsertEmployee(emp);
			if (result.EmployeeID == 0)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, "Something Went Wrong");
			}
			return Ok("Added Successfully");
		}
		[HttpPut]
		[Route("UpdateEmployee")]
		public async Task<IActionResult> Put(EmployeeAngular emp)
		{
			await _employee.UpdateEmployee(emp);
			return Ok("Updated Successfully");
		}
		[HttpDelete]
		[Route("DeleteEmployee")]
		//[HttpDelete("{id}")]
		public JsonResult Delete(int id)
		{
			var result = _employee.DeleteEmployee(id);
			return new JsonResult("Deleted Successfully");
		}

		[Route("SaveFile")]
		[HttpPost]
		public JsonResult SaveFile()
		{
			try
			{
				var httpRequest = Request.Form;
				var postedFile = httpRequest.Files[0];
				string filename = postedFile.FileName;
				var physicalPath = _env.ContentRootPath + "/Photos/" + filename;

				using (var stream = new FileStream(physicalPath, FileMode.Create))
				{
					stream.CopyTo(stream);
				}

				return new JsonResult(filename);
			}
			catch (Exception)
			{
				return new JsonResult("anonymous.png");
			}
		}
	}
}
