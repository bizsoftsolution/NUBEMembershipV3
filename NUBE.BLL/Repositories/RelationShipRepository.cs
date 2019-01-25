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
        public override int IdByName(string name)
        {
            try
            {
                return Find(x => x.Name == name).FirstOrDefault().Id;
            }
            catch (Exception ex) { }
            return 0;

        }
        public override bool ExistName(Relationship data)
        {
            if (Any(x => x.Name.ToLower() == data.Name.ToLower() && x.Id != data.Id))
            {
                return true;
            }
            return false;
        }
        public override bool IsValidName(Relationship data)
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
        public override bool IsValid(Relationship data)
        {          
            return IsValidName(data);
        }
        public override bool CanDelete(Relationship data)
        {
            return true;
        }

    }
}
