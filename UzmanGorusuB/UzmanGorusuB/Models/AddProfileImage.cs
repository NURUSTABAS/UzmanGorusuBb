namespace UzmanGorusuB.Models
{
    public class AddProfileImage
    {
        public int ApplicantID { get; set; }
        public string? ApplicantName { get; set; }
        public string? ApplicantSurname { get; set; }
        public string? ApplicantMail { get; set; }
        public int ApplicantAge { get; set; }
        public string ApplicantPassword { get; set; }
        public string? ApplicantGender { get; set; }
        public string? ApplicantUniversity { get; set; }
        public string? ApplicantUniversityDepartment { get; set; }
        public string? ApplicantGradition { get; set; }
        public string? ApplicantCertificate { get; set; }
        public string? LanguageProficiency { get; set; }
        public IFormFile ApplicantImage { get; set; }
        public bool ApplicantStatus { get; set; }
        public string? ApplicantAbout { get; set; }
    }
}
