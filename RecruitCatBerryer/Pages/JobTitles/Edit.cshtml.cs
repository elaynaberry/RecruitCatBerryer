﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RecruitCatBerryer.Data;
using RecruitCatBerryer.Pages.NewFolder;

namespace RecruitCatBerryer.Pages.JobTitles
{
    public class EditModel : PageModel
    {
        private readonly RecruitCatBerryer.Data.RecruitCatBerryerContext _context;

        public EditModel(RecruitCatBerryer.Data.RecruitCatBerryerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public JobTitle JobTitle { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            JobTitle = await _context.JobTitle.FirstOrDefaultAsync(m => m.Id == id);

            if (JobTitle == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(JobTitle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JobTitleExists(JobTitle.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool JobTitleExists(int id)
        {
            return _context.JobTitle.Any(e => e.Id == id);
        }
    }
}
