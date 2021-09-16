using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatBerryer.Pages.NewFolder
{
    public class Company
    {
        public int Id { get; set; }
        public List<Candidate> Candidates { get; set; }
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }
        public string Name { get; set; }
        public string PositionTitle { get; set; }
        public decimal MinimumSalary { get; set; }
        public decimal MaximumSalary { get; set; }
        public DateTime StartDate { get; set; }
        public string Location { get; set; }
        public int CompanySize { get; set; }
        public int? CompanyAge { get; set; }
    }
}
