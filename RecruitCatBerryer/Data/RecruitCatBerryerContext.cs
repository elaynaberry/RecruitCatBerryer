using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatBerryer.Pages.NewFolder;

namespace RecruitCatBerryer.Data
{
    public class RecruitCatBerryerContext : DbContext
    {
        public RecruitCatBerryerContext (DbContextOptions<RecruitCatBerryerContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatBerryer.Pages.NewFolder.Candidate> Candidate { get; set; }

        public DbSet<RecruitCatBerryer.Pages.NewFolder.Company> Company { get; set; }

        public DbSet<RecruitCatBerryer.Pages.NewFolder.Industry> Industry { get; set; }

        public DbSet<RecruitCatBerryer.Pages.NewFolder.JobTitle> JobTitle { get; set; }
    }
}
