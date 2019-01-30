using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUBE.DAL;

namespace NUBE.BLL.Repositories
{
    public class BankRepository : Repository<DAL.Bank>, IRepositories.IBankRepository
    {
        public BankRepository(NUBEMembershipDBContext context) : base(context)
        {
        }

        public override int IdByCode(string Code)
        {
            try
            {
                return Find(x => x.Code == Code).FirstOrDefault().Id;
            }
            catch (Exception ex) { }
            return 0;

        }
        public override bool ExistCode(Bank data)
        {
            if (Any(x => x.Code.ToLower() == data.Code.ToLower() && x.Id != data.Id))
            {
                return true;
            }
            return false;
        }
        public override bool IsValidCode(Bank data)
        {
            if (string.IsNullOrWhiteSpace(data.Code))
            {
                return false;
            }
            else if (ExistCode(data))
            {
                return false;
            }
            return true;
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
        public override bool ExistName(Bank data)
        {
            if (Any(x => x.Name.ToLower() == data.Name.ToLower() && x.Id != data.Id))
            {
                return true;
            }
            return false;
        }
        public override bool IsValidName(Bank data)
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

        public override bool IsValid(Bank data)
        {
            return IsValidName(data) && IsValidCode(data);
        }
        public override bool CanDelete(Bank data)
        {
            return true;
        }

        public override IEnumerable<Bank> ToList
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
        public override string FormTile { get; set; } = "Bank";
    }
}
