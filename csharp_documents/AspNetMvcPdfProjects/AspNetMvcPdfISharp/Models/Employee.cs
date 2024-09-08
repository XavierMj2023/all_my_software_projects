using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetMvcPdfISharp.Models
{
	public class Employees
	{
		[Key]
		public int EmployeeId {  get; set; }
		public string Name {  get; set; }
		public string Gender {  get; set; }
		public string City {  get; set; }
		public int DepartmentId {  get; set; }
		public DateTime Hire_Date { get; set; }
	}
}