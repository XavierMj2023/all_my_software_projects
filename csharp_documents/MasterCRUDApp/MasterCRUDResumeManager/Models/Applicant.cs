using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasterCRUDResumeManager.Models
{
	public class Applicant
	{
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(10)]
        public string Gender { get; set; } = "";
        [Required]
        [Range(25,55,ErrorMessage ="Currently,We have no positions vacant for your age")]
        [DisplayName("Age in Years")]
        public int Age {  get; set; }
        [Required]
        [StringLength(50)]
        public string Qualification { get; set; } = "";
        [Required]
        [Range(1,25,ErrorMessage = "Currently,We have no positions vacant for your experience")]
        [DisplayName("Total Experience in Years")]
        public int TotalExperience {  get; set; }
        public virtual List<Experience> ExperiencesList { get; set; } = new List<Experience>();


        //added in second phase
        public string PhotoUrl { get; set; }
        [Required(ErrorMessage ="Please Choose the Profle Photo")]
        [Display(Name ="Profile Photo")]
        [NotMapped ]

        //used to collect the uploaded file as a byte array
        public IFormFile ProfilePhoto { get; set; }
    }
}
