using NUBE.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NUBE.BLL.IRepositories
{
    public interface ICityRepository : IRepository<City>
    {
        IEnumerable<City> FindIncluceState(Func<City, bool> predicate);
    }
    
}
