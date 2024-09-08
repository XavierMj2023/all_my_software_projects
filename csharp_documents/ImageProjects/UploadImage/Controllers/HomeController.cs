using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UploadImage.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet]
		public ActionResult Index() 
		{
			// This method will list the table' row
			Upload_Image_DBEntities conn = new Upload_Image_DBEntities();
			return View(conn.Image_Table.ToList());
		}
		// This method will upload the image and data to the folder and database
		[HttpPost]
		public ActionResult Index(HttpPostedFileBase postedFile)
		{
			if (postedFile != null && postedFile.ContentLength > 0)
			{

				//Getting File Details
				string dir = Server.MapPath("~/Upload/");
				string name = Path.GetFileName(postedFile.FileName);
				string path = Path.Combine(dir, name);

				//Saving file to Folder
				postedFile.SaveAs(path);

				//Saving data to database
				Upload_Image_DBEntities conn = new Upload_Image_DBEntities();

				conn.Image_Table.Add(new Image_Table
				{
					Title = name,
					Image = "~/Upload/" + name // Assuming Image_Table's Image field stores a relative path
				});

				conn.SaveChanges();
			}
			else
			{
				return RedirectToAction("Index");
			}
			return RedirectToAction("Index");
		}
		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}