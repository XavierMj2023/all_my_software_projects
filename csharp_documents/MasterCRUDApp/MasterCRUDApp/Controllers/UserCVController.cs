using MasterCRUDApp.Data;
using MasterCRUDApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MasterCRUDApp.Controllers
{
	public class UserCVController : Controller
	{
		private readonly AppDbContext _context;
		private readonly IWebHostEnvironment _webHost;

		public UserCVController(AppDbContext context,IWebHostEnvironment webHost)
		{
			_context = context;
			_webHost = webHost;
		}
		public IActionResult Index()
		{
			List<Applicant> applicants;
			applicants = _context.Applicants.ToList();
			return View(applicants);
		}
		[HttpPost]
		public IActionResult Index(Applicant applicant)
		{
			applicant.Experience.Add(new Experience(){ ExperienceId = 1});
			return View(applicant);
		}
		[HttpGet]
		public IActionResult Create() 
		{ 
			Applicant applicant = new Applicant();
			applicant.Experience.Add(new Experience() { ExperienceId = 1 });
			return View(applicant);
		}
		[HttpPost]
		public IActionResult Create(Applicant applicant)
		{
			//applicant.Experience.RemoveAll(n => n.YearsOfWorked == 0);

			string uniqueFileName = GetUploadedFileName(applicant);
			applicant.PhotoUrl = uniqueFileName;
			_context.Add(applicant);
			_context.SaveChanges();
			return View();
		}
		public string GetUploadedFileName(Applicant applicant)
		{
			string uniqueFileName = null;
			if(applicant.PhotoUrl != null) 
			{
				string uploadFolder = Path.Combine(_webHost.WebRootPath, "images");
				uniqueFileName = Guid.NewGuid().ToString() + "_" + applicant.ProfilePhoto.FileName;
				string filepath = Path.Combine(uploadFolder, uniqueFileName);
				using(var filestream = new FileStream(filepath,FileMode.Create))
				{
					applicant.ProfilePhoto.CopyTo(filestream);
				}
			}
			return uniqueFileName;
		}
	}
}
