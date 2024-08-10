using System.ComponentModel.DataAnnotations;

namespace ATS.Models
{
    public class CandidateEntryDetails
    {

        [Required(ErrorMessage = "First Name is required")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Mobile Number is required")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Please enter a valid 10-digit mobile number")]
        public string? MobileNumber { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        [DataType(DataType.Date)]
        public DateTime? DOB { get; set; }

        [Required(ErrorMessage = "Aadhar Card Number is required")]
        [RegularExpression(@"^\d{12}$", ErrorMessage = "Please enter a valid 12-digit Aadhar Card number")]
        public string? AadharCardNumber { get; set; }

        [Required(ErrorMessage = "Email ID is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string? EmailID { get; set; }

        public string? OTP { get; set; }
        public string? EmailOTP { get; set; }

    }
}
