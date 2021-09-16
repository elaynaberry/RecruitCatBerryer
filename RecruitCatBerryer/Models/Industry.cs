using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatBerryer.Pages.NewFolder
{
    public class Industry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Candidate> Candidates { get; set; }
        public List<Company> Companies { get; set; }
        public decimal? AverageSalary { get; set; }
    }
}
