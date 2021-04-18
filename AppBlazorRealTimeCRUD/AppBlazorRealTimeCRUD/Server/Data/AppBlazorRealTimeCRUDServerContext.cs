using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppBlazorRealTimeCRUD.Shared;

namespace AppBlazorRealTimeCRUD.Server.Data
{
    public class AppBlazorRealTimeCRUDServerContext : DbContext
    {
        public AppBlazorRealTimeCRUDServerContext (DbContextOptions<AppBlazorRealTimeCRUDServerContext> options)
            : base(options)
        {
        }

        public DbSet<AppBlazorRealTimeCRUD.Shared.ProgrammingLanguage> ProgrammingLanguage { get; set; }
    }
}
