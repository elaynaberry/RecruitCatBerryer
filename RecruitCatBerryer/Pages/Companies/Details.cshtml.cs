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
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatBerryer.Data.RecruitCatBerryerContext _context;

        public DetailsModel(RecruitCatBerryer.Data.RecruitCatBerryerContext context)
        {
            _context = context;
        }

        public Company Company { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Company = await _context.Company
                .Include(c => c.Industry).FirstOrDefaultAsync(m => m.Id == id);

            if (Company == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
