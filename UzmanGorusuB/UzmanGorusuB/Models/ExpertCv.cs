using System.ComponentModel.DataAnnotations;

namespace UzmanGorusuB.Models
{
    public class ExpertCv
    {
       
        public int ApplicantExpertID { get; set; }
        public string ApplicantExpertName { get; set; }
        public string ApplicantExpertSurname { get; set; }
        public string ApplicantExpertMail { get; set; }
        public int ApplicantExpertAge { get; set; }
        public string ApplicantExpertGender { get; set; }
        public string ApplicantExpertTitle { get; set; }

        [Required(ErrorMessage = "CV Alanı Boş geçilemez")]
        public IFormFile ApplicantExpertCV { get; set; }
        public bool IsAccpted { get; set; }
        public bool ApplicantExpertStatus { get; set; }
    }
}
