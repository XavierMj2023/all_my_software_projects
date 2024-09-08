using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using AspNetMvcPdfISharp.Models;

namespace AspNetMvcPdfISharp.DataModelFolder
{
	public class DataModel:DbContext
	{
		public DbSet<Employees> Employees { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Employees>().ToTable("tblMyEmps");
		}

	}
}