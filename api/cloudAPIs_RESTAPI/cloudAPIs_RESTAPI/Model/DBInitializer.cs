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
                var country1 = new Country()
                {
                    Name = "Belgium",
                    ISO = "be",
                    Capital = "Brussels",
                    Surface_area = 30688,
                    Population = 11420163
                };

                var country2 = new Country()
                {
                    Name = "The Netherlands",
                    ISO = "nl",
                    Capital = "Amsterdam",
                    Surface_area = 41543,
                    Population = 17308133
                };

                context.Countries.Add(country1);
                context.Countries.Add(country2);
                context.SaveChanges();
            }
        }
    }
}
