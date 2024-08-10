using System.ComponentModel.DataAnnotations;

namespace ATS.Models
{
    public class DocumentUpload
    {
        public string PhotographfName { get; set; }

        [Required(ErrorMessage = "Photograph is required.")]
        public IFormFile Photograph { get; set; }
      

        public string AddProoffName { get; set; }
        [Required(ErrorMessage = "Proof of Address is required.")]
        public IFormFile AddProof { get; set; }
    
        public string NationalityProofName { get; set; }
        [Required(ErrorMessage = "Proof of Highest Education is required.")]
        public IFormFile NationalityProof { get; set; }

        public string HigherEduName { get; set; }
        [Required(ErrorMessage = "Last Employer is required.")]
        public IFormFile HigherEdu { get; set; }

        public string LastEmployerName { get; set; }
        [Required(ErrorMessage = "Proof of Last Emplyment is required.")]
        public IFormFile LastEmployer { get; set; }
    }
}
