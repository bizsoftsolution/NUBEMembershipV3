using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NUBE.DAL
{
    public class MemberNominee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public char Gender { get; set; }        
        public string NRIC_O { get; set; }
        public string NRIC_N { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }        
        public string PostalCode { get; set; }
        public string PhoneNo { get; set; }
        public string MobileNo { get; set; }

        public int CityId { get; set; }

        public int MemberId { get; set; }
        public Member Member { get; set; }

        public int RelatoinshipId { get; set; }
        public Relationship Relationship { get; set; }

        
    }
}
