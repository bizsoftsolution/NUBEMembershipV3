using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NUBE.DAL
{
    public class BankBranch
    {
        public int Id { get; set; }
        public int BankId { get; set; }
        public Bank Bank { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int? CityId { get; set; }
        public City City { get; set; }
        public string PostalCode { get; set; }
        public string PrimaryPhoneNo { get; set; }
        public string SecondaryPhoneNo { get; set; }
        public string EMailId { get; set; }
        public int? OrganisationBranchDetailId { get; set; }
        public OrganisationBranchDetail OrganisationBranchDetail { get; set; }
        public bool IsHeadOffice { get; set; }

        public string BankBranchCode { get; set; }
        public bool isDeleted { get; set; }
        public bool isMerged { get; set; }

        public List<Member> Members { get; set; }
    }
}
