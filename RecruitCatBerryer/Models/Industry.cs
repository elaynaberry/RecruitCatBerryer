using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecruitCatBerryer.Pages.NewFolder
{
    public class Industry
    {
        public int Id { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }
        public List<Candidate> Candidates { get; set; }
        public List<Company> Companies { get; set; }
        [Display(Name = "Average Salary")]
        [DataType(DataType.Text)]
        [Range(1, 1000000000)]
        public decimal? AverageSalary { get; set; }
    }
}
