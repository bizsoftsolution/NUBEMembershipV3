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

        public int IdByName(string name)
        {
            try
            {
                return Find(x => x.Name == name).FirstOrDefault().Id;
            }catch(Exception ex) { }
            return 0;

        }

        
    }
}
