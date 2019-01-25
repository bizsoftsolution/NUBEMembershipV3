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
        public override int IdByName(string name)
        {
            try
            {
                return Find(x => x.Name == name).FirstOrDefault().Id;
            }
            catch (Exception ex) { }
            return 0;

        }
        public override bool ExistName(City data)
        {
            if (Any(x => x.Name.ToLower() == data.Name.ToLower() && x.Id != data.Id))
            {
                return true;
            }
            return false;
        }
        public override bool IsValidName(City data)
        {
            if (string.IsNullOrWhiteSpace(data.Name))
            {
                return false;
            }
            else if (ExistName(data))
            {
                return false;
            }
            return true;
        }
        public override bool IsValid(City data)
        {
            if (!IsValidName(data)) return false;
            else if (data.StateId == 0) return false;
            return true;
        }

        public override bool CanDelete(City data)
        {
            return true;
        }

    }
}
