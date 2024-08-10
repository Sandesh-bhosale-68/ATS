namespace ATS.Models
{
    public class QualificationDetailsModel
    {
        public string? HighEducation { get; set; }
        public string? HighPassingYear { get; set; }
        public string? HSC { get; set; }
        public string? Diploma { get; set; }
        public string? Graduate { get; set; }
        public string? PostGraduate { get; set; }
        public string? SpecialCertification { get; set; }
                
        // Second set? of fields
        public string? CertificationOther { get; set; }
        public string? OtherCertificatePassingYear { get; set; }
        public string? PercentageOther { get; set; }
    }
}
