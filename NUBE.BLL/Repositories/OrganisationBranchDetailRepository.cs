using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUBE.DAL;

namespace NUBE.BLL.Repositories
{
    public class OrganisationBranchDetailRepository : Repository<DAL.OrganisationBranchDetail>, IRepositories.IOrganisationBranchDetailRepository
    {
        public OrganisationBranchDetailRepository(NUBEMembershipDBContext context) : base(context)
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
        public override bool ExistName(OrganisationBranchDetail data)
        {
            if (Any(x => x.Name.ToLower() == data.Name.ToLower() && x.Id != data.Id))
            {
                return true;
            }
            return false;
        }
        public override bool IsValidName(OrganisationBranchDetail data)
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
        public override bool IsValid(OrganisationBranchDetail data)
        {
            return IsValidName(data);
        }
        public override bool CanDelete(OrganisationBranchDetail data)
        {
            return true;
        }

        public override IEnumerable<OrganisationBranchDetail> ToList
        {
            get
            {
                try
                {
                    var rv = Find(x => String.IsNullOrWhiteSpace(SearchText) || x.Name.ToLower().Contains(SearchText.ToLower())).ToList();
                    return rv;
                }
                catch (Exception ex)
                {

                }
                return base.ToList;
            }
        }
        public override string FormTile { get; set; } = "Organisation Branch Detail";
    }
}
