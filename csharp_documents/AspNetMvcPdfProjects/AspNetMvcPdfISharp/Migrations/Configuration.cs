namespace AspNetMvcPdfISharp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
	using AspNetMvcPdfISharp.Models;

	internal sealed class Configuration : DbMigrationsConfiguration<AspNetMvcPdfISharp.DataModelFolder.DataModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AspNetMvcPdfISharp.DataModelFolder.DataModel context)
        {
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method
			//  to avoid creating duplicate seed data.
			// Adding or updating an employee

			context.Employees.AddOrUpdate(
				e => e.EmployeeId, // Assuming Id is the primary key
				new Employees 
				{ 
					EmployeeId = 1, 
					Name = "John Doe",
					Gender = "Male",
					City = "Mumbai",
					DepartmentId = 1 ,
					Hire_Date = new DateTime(2023,12,11)
				},
				new Employees
				{
					EmployeeId = 2,
					Name = "John Mangal",
					Gender = "Male",
					City = "Mumbai",
					DepartmentId = 3,
					Hire_Date = new DateTime(2023, 12, 10)
				},
				new Employees
				{
					EmployeeId = 3,
					Name = "Doe",
					Gender = "Female",
					City = "Galwar",
					DepartmentId = 4,
					Hire_Date = new DateTime(2023, 09, 11)
				},
				new Employees
				{
					EmployeeId = 4,
					Name = "Singayya",
					Gender = "Female",
					City = "Galwar",
					DepartmentId = 2,
					Hire_Date = new DateTime(2023, 09, 09)
				},
				new Employees
				{
					EmployeeId = 5,
					Name = "Yawanna",
					Gender = "Male",
					City = "Galwar",
					DepartmentId = 4,
					Hire_Date = new DateTime(2023, 09, 11)
				},
				new Employees
				{
					EmployeeId = 6,
					Name = "Doe",
					Gender = "Female",
					City = "Galwar",
					DepartmentId = 4,
					Hire_Date = new DateTime(2023, 09, 11)
				},
				new Employees
				{
					EmployeeId = 7,
					Name = "Doe2",
					Gender = "Female",
					City = "Galwar",
					DepartmentId = 4,
					Hire_Date = new DateTime(2023, 09, 11)
				},
				new Employees
				{
					EmployeeId = 8,
					Name = "Doe3",
					Gender = "Female",
					City = "Galwar",
					DepartmentId = 4,
					Hire_Date = new DateTime(2023, 09, 11)
				},
				new Employees
				{
					EmployeeId = 9,
					Name = "Doe4",
					Gender = "Female",
					City = "Galwar",
					DepartmentId = 4,
					Hire_Date = new DateTime(2023, 09, 11)
				},
				new Employees
				{
					EmployeeId = 10,
					Name = "Doe5",
					Gender = "Female",
					City = "Galwar",
					DepartmentId = 4,
					Hire_Date = new DateTime(2023, 09, 11)
				}
			// Add more employees as needed
			);

			// Save changes to the database
			context.SaveChanges();

		}
    }
}
