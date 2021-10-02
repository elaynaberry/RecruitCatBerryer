using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecruitCatBerryer.Pages.NewFolder
{
    public class JobTitle
    {
        public int Id { get; set; }
        public List<Candidate> Candidates { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }
        [Display(Name = "Minimum Salary")]
        [DataType(DataType.Currency)]
        [Range(1,1000000000)]
        [Required]
        public decimal MinimumSalary { get; set; }
        [Display(Name = "Maximum Salary")]
        [DataType(DataType.Text)]
        [Range(1,1000000000)]
        public decimal MaximumSalary { get; set; }
        [Display(Name = "Degree Required")]
        public bool DegreeRequired { get; set; }
    }
}
