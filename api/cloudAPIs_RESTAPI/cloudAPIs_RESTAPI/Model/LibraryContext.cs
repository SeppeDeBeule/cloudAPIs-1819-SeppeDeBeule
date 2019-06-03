using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cloudAPIs_RESTAPI.Model
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options)
                            : base(options)
        {

        }
        public DbSet<Country> Countries { get; set; }
    }
}
