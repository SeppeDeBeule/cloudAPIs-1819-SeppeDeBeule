using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cloudAPIs_RESTAPI.Model
{
    public class Country
    {
        public int Id { get; set; }

        [Required]
        [StringLength(96)]
        public string Name { get; set; }

        [StringLength(2)]
        public string ISO { get; set; }

        [StringLength(96)]
        public string Capital { get; set; }
        public int Surface_area { get; set; }
        public int Population { get; set; }
    }
}
