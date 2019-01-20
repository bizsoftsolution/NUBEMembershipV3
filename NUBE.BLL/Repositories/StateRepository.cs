using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUBE.DAL;
using Microsoft.EntityFrameworkCore;

namespace NUBE.BLL.Repositories
{
    public class StateRepository : Repository<DAL.State>, IRepositories.IStateRepository
    {
        public StateRepository(NUBEMembershipDBContext context) : base(context)
        {
        }

        public IEnumerable<State> FindIncluceCountry(Func<State, bool> predicate)
        {
            return _context.States.Include(x => x.Country).Where(predicate).ToList();
        }
    }
}
