using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NUBE.DAL
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string StateCode { get; set; }
        public bool isDeleted { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }

        public List<City> Cities { get; set; }


    }
}
