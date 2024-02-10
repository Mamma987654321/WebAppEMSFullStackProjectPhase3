using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppEMSFullStackProject.Models;

namespace WebAppEMSFullStackProject.Data
{
    public class EmpProfileContext : DbContext
    {
        public EmpProfileContext (DbContextOptions<EmpProfileContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppEMSFullStackProject.Models.EmpProfile> EmpProfile { get; set; } = default!;
    }
}
