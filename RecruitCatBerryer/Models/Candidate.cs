using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecruitCatBerryer.Pages.NewFolder
{
    public class Candidate
    {
    public int Id { get; set; }
        [Display(Name ="Job Title")]
        [DataType(DataType.Text)]
        public JobTitle JobTitle { get; set; }
        [Range(1, 1000000000)]
        public int JobTitleId { get; set; }
        public Company Company { get; set; }
        [Range(1, 1000000000)]
        public int? CompanyId { get; set; }
        public Industry Industry { get; set; }
        [Range(1, 1000000000)]
        public int IndustryId { get; set; }
        [Display(Name = "First Name")]
        [DataType(DataType.Text)]
        [Required]
        [StringLength(60, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [DataType(DataType.Text)]
        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string LastName { get; set; }
        [Display(Name = "Target Salary")]
        [DataType(DataType.Text)]
        [Range(1, 1000000000)]
        [Required]
        public decimal TargetSalary { get; set; }
        [Display(Name = "Start Date")]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }
        [Display(Name = "Years in School")]
        [DataType(DataType.Text)]
        [Range(0, 20)]
        [Required]
        public int YearsInSchool { get; set; }
        [Display(Name = "State of Residency")]
        [DataType(DataType.Text)]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string StateOfResidency { get; set; }

    }
}
