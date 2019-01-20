using NUBE.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NUBE.BLL.IRepositories
{
    public interface IStateRepository : IRepository<State>
    {
        IEnumerable<State> FindIncluceCountry(Func<State, bool> predicate);
    }    
}
