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

                var country3 = new Country()
                {
                    Name = "France",
                    ISO = "fr",
                    Capital = "Paris",
                    Surface_area = 640679,
                    Population = 67348000
                };

                var country4 = new Country()
                {
                    Name = "Luxembourg",
                    ISO = "lu",
                    Capital = "Luxembourg",
                    Surface_area = 2586,
                    Population = 602005
                };

                var country5 = new Country()
                {
                    Name = "Germany",
                    ISO = "de",
                    Capital = "Berlin",
                    Surface_area = 357386,
                    Population = 83000000
                };

                var country6 = new Country()
                {
                    Name = "United Kingdom",
                    ISO = "gb",
                    Capital = "London",
                    Surface_area = 242495,
                    Population = 66921307
                };

                var country7 = new Country()
                {
                    Name = "Australia",
                    ISO = "au",
                    Capital = "Canberra",
                    Surface_area = 7692024,
                    Population = 25380900
                };

                var country8 = new Country()
                {
                    Name = "Russia",
                    ISO = "ru",
                    Capital = "Moscow",
                    Surface_area = 17125191,
                    Population = 146793744
                };

                var country9 = new Country()
                {
                    Name = "United States",
                    ISO = "us",
                    Capital = "Washington D.C.",
                    Surface_area = 9833520,
                    Population = 327167434
                };

                var country10 = new Country()
                {
                    Name = "Brazil",
                    ISO = "br",
                    Capital = "Brasilia",
                    Surface_area = 8515767,
                    Population = 210147125
                };

                var country11 = new Country()
                {
                    Name = "South Africa",
                    ISO = "za",
                    Capital = "Cape Town",
                    Surface_area = 1221037,
                    Population = 57725600
                };

                var country12 = new Country()
                {
                    Name = "India",
                    ISO = "in",
                    Capital = "New Delhi",
                    Surface_area = 3287263,
                    Population = 1324171354
                };

                var country13 = new Country()
                {
                    Name = "China",
                    ISO = "cn",
                    Capital = "Beijing",
                    Surface_area = 9596961,
                    Population = 1403500365
                };

                var country14 = new Country()
                {
                    Name = "United Arab Emirates",
                    ISO = "ae",
                    Capital = "Abu Dhabi",
                    Surface_area = 83600,
                    Population = 9599353
                };

                var country15 = new Country()
                {
                    Name = "Egypt",
                    ISO = "eg",
                    Capital = "Cairo",
                    Surface_area = 1010408,
                    Population = 94798927
                };

                var country16 = new Country()
                {
                    Name = "Singapore",
                    ISO = "sg",
                    Capital = "Singapore",
                    Surface_area = 723,
                    Population = 5638700
                };


                context.Countries.Add(country1);
                context.Countries.Add(country2);
                context.Countries.Add(country3);
                context.Countries.Add(country4);
                context.Countries.Add(country5);
                context.Countries.Add(country6);
                context.Countries.Add(country7);
                context.Countries.Add(country8);
                context.Countries.Add(country9);
                context.Countries.Add(country10);
                context.Countries.Add(country11);
                context.Countries.Add(country12);
                context.Countries.Add(country13);
                context.Countries.Add(country14);
                context.Countries.Add(country15);
                context.Countries.Add(country16);
                context.SaveChanges();
            }
        }
    }
}
