using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ApplicantExpert
    {
        [Key]
        public int ApplicantExpertID { get; set; }
        public string ApplicantExpertName { get; set; }
        public string ApplicantExpertSurname { get; set; }
        public string ApplicantExpertMail { get; set; }
        public int ApplicantExpertAge { get; set; }
        public string? ApplicantExpertGender { get; set; }
        public string ApplicantExpertTitle { get; set; }
        public string? ApplicantExpertCV { get; set; }
        public bool Discussed { get; set; }
        public bool IsAccpted { get; set; }
        public bool ApplicantExpertStatus { get; set; }

    }
}
