using MasterCRUDResumeManager.Data;
using MasterCRUDResumeManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace MasterCRUDResumeManager.Controllers
{
    public class ResumeController : Controller
    {
        private readonly ResumeDbContext _context;

        private readonly IWebHostEnvironment _webHost;
        public ResumeController(ResumeDbContext context,IWebHostEnvironment webHost)
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
        [HttpGet]
        public IActionResult Create() 
        { 
            Applicant applicant = new Applicant();
            applicant.ExperiencesList.Add(new Experience() { ExperienceId = 1});
            //applicant.Experience.Add(new Experience() { ExperienceId = 2});
            //applicant.Experience.Add(new Experience() { ExperienceId = 3});
            return View(applicant);
        }
        [HttpPost]
        public IActionResult Create(Applicant applicant)
        {
            string uniqueFileName = GetUploadedFileName(applicant);
            applicant.PhotoUrl = uniqueFileName;
            _context.Add(applicant);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
		private string GetUploadedFileName(Applicant applicant)
		{
			string uniqueFileName = null;
			if (applicant.ProfilePhoto != null)
			{
				string uploadFolder = Path.Combine(_webHost.WebRootPath, "images");
				uniqueFileName = Guid.NewGuid().ToString() + "_" + applicant.ProfilePhoto.FileName;
				string filepath = Path.Combine(uploadFolder, uniqueFileName);
				using (var filestream = new FileStream(filepath, FileMode.Create))
				{
					applicant.ProfilePhoto.CopyTo(filestream);
				}
			}
			return uniqueFileName;
		}

	}
}
