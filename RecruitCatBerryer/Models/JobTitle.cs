using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatBerryer.Pages.NewFolder
{
    public class JobTitle
    {
        public int Id { get; set; }
        public List<Candidate> Candidates { get; set; }
        public string Title { get; set; }
        public decimal MinimumSalary { get; set; }
        public decimal MaximumSalary { get; set; }
        public bool DegreeRequired { get; set; }
    }
}
