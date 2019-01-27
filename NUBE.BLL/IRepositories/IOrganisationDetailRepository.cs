using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NUBE.BLL.IRepositories
{
    public interface IOrganisationDetailRepository:IRepository<DAL.OrganisationDetail>
    {
        DAL.OrganisationDetail GetOrganisationDetail();
    }
}
