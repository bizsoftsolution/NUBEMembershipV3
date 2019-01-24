using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUBE.DAL;
using Microsoft.EntityFrameworkCore;

namespace NUBE.BLL.Repositories
{
    public class CityRepository : Repository<DAL.City>, IRepositories.ICityRepository
    {
        public CityRepository(NUBEMembershipDBContext context) : base(context)
        {
        }

        public IEnumerable<City> FindIncluceState(Func<City, bool> predicate)
        {
            return _context.Cities.Include(x => x.State).Where(predicate).ToList();
        }
    }
}
