using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NUBE.BLL.IRepositories
{
    public interface IOrganisationDetailRepository:IRepository<DAL.OrganisationDetail>
    {
        void GetOrganisationDetail();

        string CityName { get; set; }
        string StateName { get; set; }
        string CountryName { get; set; }
    }
}
