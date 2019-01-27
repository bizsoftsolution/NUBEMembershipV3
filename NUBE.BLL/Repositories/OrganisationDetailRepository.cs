using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUBE.DAL;
using Microsoft.EntityFrameworkCore;
namespace NUBE.BLL.Repositories
{
    public class OrganisationDetailRepository : Repository<OrganisationDetail>, IRepositories.IOrganisationDetailRepository
    {
        public OrganisationDetailRepository(NUBEMembershipDBContext context) : base(context)
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
        public override bool ExistName(OrganisationDetail data)
        {
            if (Any(x => x.Name.ToLower() == data.Name.ToLower() && x.Id != data.Id))
            {
                return true;
            }
            return false;
        }
        public override bool IsValidName(OrganisationDetail data)
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
        public override bool IsValid(OrganisationDetail data)
        {
            return IsValidName(data);
        }
        public override bool CanDelete(OrganisationDetail data)
        {
            return true;
        }

        public OrganisationDetail GetOrganisationDetail()
        {            
            return _context.OrganisationDetails.Include(x=> x.City).FirstOrDefault();
        }
    }
}
