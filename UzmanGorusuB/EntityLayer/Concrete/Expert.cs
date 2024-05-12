using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Expert
    {
        [Key]
        public int ExpertID { get; set; }
        public string? ExpertName { get; set; }
        public string? ExpertSurname { get; set; }
        public string? ExpertMail { get; set; }
        public int? ExpertAge { get; set; }
        public string? ExpertGender { get; set; }
        public string? ExpertDescription { get; set; }
        public string? ExpertTitle { get; set; }
        public DateTime MembershipDate { get; set; }
        public bool? ExpertStatus { get; set; }
        public string? ExpertImage { get; set; }

       
        public List<Comment> Comments { get; set; }
       
    }
}
