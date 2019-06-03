using cloudAPIs_RESTAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace cloudAPIs_RESTAPI.Controllers
{
    [Route("api/v1/countries")]
    public class CountryController : ControllerBase
    {
        public LibraryContext context { get; set; }
        public CountryController(LibraryContext _context)
        {
            context = _context;
        }

        // List all countries
        [HttpGet]
        public List<Country> GetCountries(string name, string capital, int? page, string sort, int limit = 20, string dir = "asc")
        {
            IQueryable<Country> query = context.Countries;

            if (!string.IsNullOrWhiteSpace(name)) { query = query.Where(d => d.Name == name); }
            if (!string.IsNullOrWhiteSpace(capital)) { query = query.Where(d => d.Capital == capital); }

            if(!string.IsNullOrWhiteSpace(sort))
            {
                switch (sort)
                {
                    case "name":
                        if (dir == "asc") { query = query.OrderBy(d => d.Name); }
                        else if (dir == "desc") { query = query.OrderByDescending(d => d.Name); }
                        break;
                    case "capital":
                        if (dir == "asc") { query = query.OrderBy(d => d.Capital); }
                        else if (dir == "desc") { query = query.OrderByDescending(d => d.Capital); }
                        break;
                    case "iso":
                        if (dir == "asc") { query = query.OrderBy(d => d.ISO); }
                        else if (dir == "desc") { query = query.OrderByDescending(d => d.ISO); }
                        break;
                    case "surface_area":
                        if (dir == "asc") { query = query.OrderBy(d => d.Surface_area); }
                        else if (dir == "desc") { query = query.OrderByDescending(d => d.Surface_area); }
                        break;
                    case "population":
                        if (dir == "asc") { query = query.OrderBy(d => d.Population); }
                        else if (dir == "desc") { query = query.OrderByDescending(d => d.Population); }
                        break;
                }
            }

            if(page.HasValue)
            {
                query = query.Skip((page.Value - 1) * limit);
            }
            query = query.Take(limit);

            return query.ToList();
        }

        // Retrieve a country with given ID
        [Route("{id}")]
        [HttpGet]
        public ActionResult<Country> GetCountry(int id)
        {
            var country = context.Countries.Find(id);
            if (country == null)
            {
                return NotFound();
            } else
            {
                return Ok(country);
            }
        }

        // Delete a country with given ID
        [Route("{id}")]
        [HttpDelete]
        public IActionResult DeleteCountry(int id)
        {
            var country = context.Countries.Find(id);
            if (country == null) { return NotFound(); }
            else
            {
                context.Countries.Remove(country);
                context.SaveChanges();

                return NoContent();
            }
        }

        // Add a new country (assign ID automatically)
        [HttpPost]
        public ActionResult<Country> AddCountry([FromBody]Country newCountry)
        {
            context.Countries.Add(newCountry);
            context.SaveChanges();
            return Created("", newCountry);
        }

        // Update an existing country given its ID
        [HttpPut]
        public IActionResult UpdateCountry([FromBody] Country updateCountry)
        {
            var orgCountry = context.Countries.Find(updateCountry.Id);
            if(orgCountry == null)
            {
                return NotFound();
            } else
            {
                // Put new values in
                orgCountry.Name = updateCountry.Name;
                orgCountry.Capital = updateCountry.Capital;
                orgCountry.ISO = updateCountry.ISO;
                orgCountry.Surface_area = updateCountry.Surface_area;
                orgCountry.Population = updateCountry.Population;

                context.SaveChanges();
                return Ok(orgCountry);
            }
        }
    }
}
