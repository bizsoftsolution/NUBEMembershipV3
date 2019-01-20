using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUBE.BLL.IRepositories;
using NUBE.DAL;

namespace NUBE.BLL.Repositories
{
    public class RelationShipRepository : Repository<Relationship>, IRelationShipRepository
    {
        public RelationShipRepository(NUBEMembershipDBContext context) : base(context)
        {
        }
    }
}
