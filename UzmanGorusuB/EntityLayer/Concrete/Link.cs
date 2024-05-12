using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Link
    {
        [Key]
        public int LinkID { get; set; }
        public string? LinkTitle { get; set; }
        public string LinkContent { get; set; }
        public DateTime? LinkDate { get; set; }
        public bool LinkStatus { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public int ApplicantID { get; set; }
        public Applicant Applicant { get; set; }
    }
}
