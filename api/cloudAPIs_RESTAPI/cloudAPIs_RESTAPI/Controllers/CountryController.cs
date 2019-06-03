using cloudAPIs_RESTAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace cloudAPIs_RESTAPI.Controllers
{
    [Route("api/v1/countries")]
    public class CountryController : ControllerBase
    {
        static List<Country> list = new List<Country>();

        static CountryController()
        {
            list.Add(new Country()
            {
                Id = 1,
                Name = "Belgium",
                ISO = "be",
                Capital = "Brussels",
                Surface_area = 30688,
                Population = 11420163
            });

            list.Add(new Country()
            {
                Id = 2,
                Name = "The Netherlands",
                ISO = "nl",
                Capital = "Amsterdam",
                Surface_area = 41543,
                Population = 17308133
            });
        }

        // List all countries
        [HttpGet]
        public List<Country> GetCountries()
        {
            return list;
        }

        // Retrieve a country with given ID
        [Route("{id}")]
        [HttpGet]
        public ActionResult<Country> GetCountry(int id)
        {
            if (list.Exists(country => country.Id == id))
                return list.First(country => country.Id == id);
            else
                return NotFound();
        }

        // Delete a country with given ID
        [Route("{id}")]
        [HttpDelete]
        public IActionResult DeleteCountry(int id)
        {
            if (list.Exists(country => country.Id == id))
            {
                var country = list.First(i => i.Id == id);
                list.Remove(country);
                return NoContent();
            }
            else
                // Country with given ID was not found
                return NotFound();
        }


        // Add a new country (assign ID automatically)
        [HttpPost]
        public ActionResult<Country> AddCountry([FromBody]Country country)
        {
            
            var max = list.Max(i => i.Id);
            country.Id = max + 1;
            list.Add(country);
            

            return Created("", country);
        }
    }
}
