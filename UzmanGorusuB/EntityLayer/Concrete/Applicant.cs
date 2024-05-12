using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Applicant
    {
        [Key]
        public int ApplicantID { get; set; }
        public string? ApplicantName { get; set; }
        public string? ApplicantSurname { get; set; }
        public string? ApplicantMail { get; set; }
        public int? ApplicantAge { get; set; }
        public string? ApplicantPassword { get; set; }
        public string? ApplicantGender { get; set; }
        public string? ApplicantUniversity { get; set; }
        public string? ApplicantUniversityDepartment { get; set; }
        public string? ApplicantGradition { get; set; }
        public string? ApplicantCertificate { get; set; }
        public string? LanguageProficiency { get; set; }
        public string? ApplicantImage { get; set; }
        public bool? ApplicantStatus { get; set; }
        public string? ApplicantAbout { get; set; }
        public List<Link> Links { get; set; }

        public virtual ICollection<Message2> WriterSender { get; set; } 
        public virtual ICollection<Message2> WriterReciever { get; set; } 


    }
}
