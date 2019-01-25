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

        public override int IdByName(string name)
        {
            try
            {
                return Find(x => x.Name == name).FirstOrDefault().Id;
            }
            catch (Exception ex) { }
            return 0;

        }
        public override bool ExistName(State data)
        {
            if (Any(x => x.Name.ToLower() == data.Name.ToLower() && x.Id != data.Id))
            {
                return true;
            }
            return false;
        }
        public override bool IsValidName(State data)
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
        public override bool IsValid(State data)
        {
            if (!IsValidName(data)) return false;
            else if (data.CountryId == 0) return false;
            return true;
        }

        public override bool CanDelete(State data)
        {
            return _context.Cities.Count(x => x.StateId == data.Id) == 0;
        }

    }
}
