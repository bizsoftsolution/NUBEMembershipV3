using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUBE.DAL;

namespace NUBE.BLL.Repositories
{
    public class StateRepository : Repository<DAL.State>, IRepositories.IStateRepository
    {
        public StateRepository(NUBEMembershipDBContext context) : base(context)
        {
        }
    }
}
