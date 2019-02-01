using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NUBE.BLL.IRepositories
{
    public interface IBankBranchRepository : IRepository<DAL.BankBranch>
    {
        string OrganisationBranchDetailName { get; set; }
        string BankCode { get; set; }
        string BankName { get; set; }
        string CityName { get; set; }
        string StateName { get; set; }
        string CountryName { get; set; } 
    }
}
