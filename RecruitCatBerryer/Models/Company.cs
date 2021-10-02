using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecruitCatBerryer.Pages.NewFolder
{
    public class Company
    {
        public int Id { get; set; }
        public List<Candidate> Candidates { get; set; }
        public Industry Industry { get; set; }
        [Display(Name = "Industry ID")]
        [DataType(DataType.Text)]
        [Range(1, 1000000000)]
        public int IndustryId { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "Position Title")]
        [DataType(DataType.Text)]
        [Required]
        public string PositionTitle { get; set; }
        [Required]
        [Display(Name = "Minimum Salary")]
        [DataType(DataType.Text)]
        [Range(1,1000000000)]
        public decimal MinimumSalary { get; set; }
        [Display(Name = "Maximum Salary")]
        [DataType(DataType.Text)]
        [Range(1,1000000000)]
        public decimal MaximumSalary { get; set; }
        [Display(Name = "Start Date")]
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public string Location { get; set; }
        [Display(Name = "Company Size")]
        [DataType(DataType.Text)]
        [Range(1,1000000000)]
        public int CompanySize { get; set; }
        [Display(Name = "Company Age")]
        [DataType(DataType.Text)]
        [Range(0,4000)]
        public int? CompanyAge { get; set; }
    }
}
