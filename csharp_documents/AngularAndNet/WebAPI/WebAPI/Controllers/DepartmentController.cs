﻿using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Repository;

namespace WebAPI.Controllers
{
	public class DepartmentController : Controller
	{
		private readonly IDepartmentRepository _department;
		public DepartmentController(IDepartmentRepository department)
		{
			_department = department ??
				throw new ArgumentNullException(nameof(department));
		}
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		[Route("GetDepartment")]
		public async Task<IActionResult> GetAllDepartmentNames()
		{
			return Ok(await _department.GetDepartment());
		}
		[HttpGet]
		[Route("GetDepartmentByID/{Id}")]
		public async Task<IActionResult> GetDeptById(int Id)
		{
			return Ok(await _department.GetDepartmentByID(Id));
		}
		[HttpPost]
		[Route("AddDepartment")]
		public async Task<IActionResult> Post(Department dep)
		{
			var result = await _department.InsertDepartment(dep);
			if (result.DepartmentId == 0)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, "Something Went Wrong");
			}
			return Ok("Added Successfully");
		}
		[HttpPut]
		[Route("UpdateDepartment")]
		public async Task<IActionResult> Put(Department dep)
		{
			await _department.UpdateDepartment(dep);
			return Ok("Updated Successfully");
		}
		[HttpDelete]
		//[HttpDelete("{id}")]
		[Route("DeleteDepartment")]
		public JsonResult Delete(int id)
		{
			_department.DeleteDepartment(id);
			return new JsonResult("Deleted Successfully");
		}
	}
}