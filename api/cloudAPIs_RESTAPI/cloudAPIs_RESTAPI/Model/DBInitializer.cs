using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cloudAPIs_RESTAPI.Model
{
    public class DBInitializer
    {
        public static void Initialize(LibraryContext context)
        {
            //Create the db if not yet exists
            context.Database.EnsureCreated();
            
            if (!context.Countries.Any())
            {
                // What do if no countries are present
            }
        }
    }
}
