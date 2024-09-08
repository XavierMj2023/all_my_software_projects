using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasterCRUDResumeManager.Models
{
	public class Experience
	{
        public Experience()
        {
        }
        [Key]
        public int ExperienceId { get; set; }
        [ForeignKey("Applicant")]
        public int ApplicantId { get; set; }
        public virtual Applicant Applicant { get; private set; }
        public string CompanyName { get; set; }
        public string Designation { get; set; }
        [Required]
		[Range(1, 25, ErrorMessage = "You must be between 1 and 25")]
		public int YearsOfWorked{ get; set; }
    }
}
