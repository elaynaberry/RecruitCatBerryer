using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatBerryer.Data;
using RecruitCatBerryer.Pages.NewFolder;

namespace RecruitCatBerryer.Pages.Industries
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatBerryer.Data.RecruitCatBerryerContext _context;

        public DetailsModel(RecruitCatBerryer.Data.RecruitCatBerryerContext context)
        {
            _context = context;
        }

        public Industry Industry { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Industry = await _context.Industry.FirstOrDefaultAsync(m => m.Id == id);

            if (Industry == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
