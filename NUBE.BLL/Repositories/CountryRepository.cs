using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUBE.DAL;

namespace NUBE.BLL.Repositories
{
    public class CountryRepository : Repository<DAL.Country>, IRepositories.ICountryRepository
    {
        public CountryRepository(NUBEMembershipDBContext context) : base(context)
        {
        }
    }
}
