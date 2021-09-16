using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatBerryer.Data;
using RecruitCatBerryer.Pages.NewFolder;

namespace RecruitCatBerryer.Pages.JobTitles
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatBerryer.Data.RecruitCatBerryerContext _context;

        public IndexModel(RecruitCatBerryer.Data.RecruitCatBerryerContext context)
        {
            _context = context;
        }

        public IList<JobTitle> JobTitle { get;set; }

        public async Task OnGetAsync()
        {
            JobTitle = await _context.JobTitle.ToListAsync();
        }
    }
}
