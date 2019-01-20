using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUBE.DAL;

namespace NUBE.BLL.Repositories
{
    public class CityRepository : Repository<DAL.City>, IRepositories.ICityRepository
    {
        public CityRepository(NUBEMembershipDBContext context) : base(context)
        {
        }
    }
}
