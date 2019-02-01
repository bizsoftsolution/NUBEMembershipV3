using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NUBE.DAL
{
    public class OrganisationBranchDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<BankBranch> BankBranches { get; set; }
    }
}
