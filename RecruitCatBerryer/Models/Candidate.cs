using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatBerryer.Pages.NewFolder
{
    public class Candidate
    {
    public int Id { get; set; }
        public JobTitle JobTitle { get; set; }
        public int JobTitleId { get; set; }
        public Company Company { get; set; }
        public int? CompanyId { get; set; }
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal TargetSalary { get; set; }
        public DateTime StartDate { get; set; }
        public int YearsInSchool { get; set; }
        public string StateOfResidency { get; set; }

    }
}
