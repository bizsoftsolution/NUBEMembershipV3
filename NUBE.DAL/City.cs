using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NUBE.DAL
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string CityCode { get; set; }
        public bool isDeleted { get; set; }

        public int StateId { get; set; }
        public State State { get; set; }
        public List<OrganisationDetail> OrganisationDetails { get; set; }
        public List<BankBranch> BankBranches { get; set; }
        public List<Member> Members { get; set; }        
       
    }
}
