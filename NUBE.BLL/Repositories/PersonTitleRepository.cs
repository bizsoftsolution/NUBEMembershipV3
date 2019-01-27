using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUBE.DAL;

namespace NUBE.BLL.Repositories
{
    public class PersonTitleRepository : Repository<DAL.PersonTitle>, IRepositories.IPersonTitleRepository
    {
        public PersonTitleRepository(NUBEMembershipDBContext context) : base(context)
        {

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
        public override bool ExistName(PersonTitle data)
        {
            if (Any(x => x.Name.ToLower() == data.Name.ToLower() && x.Id != data.Id))
            {
                return true;
            }
            return false;
        }
        public override bool IsValidName(PersonTitle data)
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
        public override bool IsValid(PersonTitle data)
        {
            return IsValidName(data);
        }
        public override bool CanDelete(PersonTitle data)
        {
            return true;
        }
    }
}
