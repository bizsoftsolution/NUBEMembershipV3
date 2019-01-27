using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NUBE.DAL
{
    public class OrganisationDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNo { get; set; }
    }
}
