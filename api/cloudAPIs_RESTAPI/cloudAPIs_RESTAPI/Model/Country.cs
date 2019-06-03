using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cloudAPIs_RESTAPI.Model
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ISO { get; set; }
        public string Capital { get; set; }
        public int Surface_area { get; set; }
        public int Population { get; set; }
    }
}
