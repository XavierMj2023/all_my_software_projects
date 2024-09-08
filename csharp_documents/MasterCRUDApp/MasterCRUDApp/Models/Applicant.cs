using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasterCRUDApp.Models
{
	public class Applicant
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[StringLength(50)]
		public string Name { get; set; } = "";
		[Required(ErrorMessage ="Please Enter Mail Id")]
		[DisplayName("Email Id")]
		public string Email { get; set; }
		[Required(ErrorMessage = "Please Enter Contact Number")]
		[DisplayName("Contact Number")]
		public string ContactNo { get; set; } = "";
		[Required]
		[StringLength(10)]
		public string Gender { get; set; } = "";
		[Required(ErrorMessage = "Please Select Date Of Birth")]
		[DisplayName("Date of Birth")]
		public DateTime DOB {  get; set; }
		[Required]
		[StringLength(50)]
		[DisplayName("Qualification")]
		public String Qualification { get; set; }
		[Required]
		[Range(1,25,ErrorMessage ="Currently we have no positions vacant for your experience")]
		[DisplayName("Experience")]
		public int TotalExperience { get; set; }
		public virtual List<Experience> Experience { get; set; } = new List<Experience>();
		public string PhotoUrl {  get; set; }
		[Required(ErrorMessage ="Please choose your Profile photo")]
		[Display(Name = "Profile Photo")]
		[NotMapped]
		public IFormFile ProfilePhoto { get; set; }
	}
}
