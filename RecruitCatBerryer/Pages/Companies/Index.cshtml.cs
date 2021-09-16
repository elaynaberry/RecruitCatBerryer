using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatBerryer.Data;
using RecruitCatBerryer.Pages.NewFolder;

namespace RecruitCatBerryer.Pages.Companies
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatBerryer.Data.RecruitCatBerryerContext _context;

        public IndexModel(RecruitCatBerryer.Data.RecruitCatBerryerContext context)
        {
            _context = context;
        }

        public IList<Company> Company { get;set; }

        public async Task OnGetAsync()
        {
            Company = await _context.Company
                .Include(c => c.Industry).ToListAsync();
        }
    }
}
