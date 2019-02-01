using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUBE.DAL;
using Microsoft.EntityFrameworkCore;
namespace NUBE.BLL.Repositories
{
    public class BankBranchRepository : Repository<DAL.BankBranch>, IRepositories.IBankBranchRepository
    {
        public BankBranchRepository(NUBEMembershipDBContext context) : base(context)
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
        public override bool ExistCode(BankBranch data)
        {
            if (Any(x => x.Code.ToLower() == data.Code.ToLower() && x.Id != data.Id))
            {
                return true;
            }
            return false;
        }
        public override bool IsValidCode(BankBranch data)
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
        public override bool ExistName(BankBranch data)
        {
            if (Any(x => x.Name.ToLower() == data.Name.ToLower() && x.Id != data.Id))
            {
                return true;
            }
            return false;
        }
        public override bool IsValidName(BankBranch data)
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

        public override bool IsValid(BankBranch data)
        {
            return IsValidName(data) && IsValidCode(data) && data.BankId>0 && data.OrganisationBranchDetailId>0 && data.CityId>0;
        }
        public override bool CanDelete(BankBranch data)
        {
            return true;
        }

        public override IEnumerable<BankBranch> ToList
        {
            get
            {
                try
                {
                    var rv = _context.BankBranches.Include(x => x.OrganisationBranchDetail).Include(x=> x.Bank)
                                                  .Include(x=> x.City).ThenInclude(x=> x.State).ThenInclude(x=> x.Country)
                                                  .Where(x => String.IsNullOrWhiteSpace(SearchText) 
                                                            || x.Name.ToLower().Contains(SearchText.ToLower())
                                                        )
                                                  .ToList();
                    return rv;
                }
                catch (Exception ex)
                {

                }
                return base.ToList;
            }
        }
        public override string FormTile { get; set; } = "Bank Branch";


        private string _BankCode;
        public string BankCode
        {
            get { return _BankCode; }
            set
            {
                if (_BankCode != value)
                {
                    _BankCode = value;
                    BankName = "";
                    if (string.IsNullOrWhiteSpace(BankCode))
                    {
                        data.BankId = 0;
                    }
                    else
                    {
                        try
                        {
                            var b = _context.Banks.FirstOrDefault(x => x.Code == BankCode);
                            if (b != null)
                            {
                                data.BankId = b.Id;
                                BankName = b.Name;
                            }                            
                        }
                        catch (Exception ex) { data.BankId = 0; }
                    }                   
                    NotifyStateChanged();
                }
            }
        }
        public string BankName { get; set; }

        private string _OrganisationBranchDetailName;
        public string OrganisationBranchDetailName
        {
            get { return _OrganisationBranchDetailName; }
            set
            {
                if (_OrganisationBranchDetailName != value)
                {
                    _OrganisationBranchDetailName = value;
                    if (string.IsNullOrWhiteSpace(OrganisationBranchDetailName))
                    {
                        data.OrganisationBranchDetailId = 0;
                    }
                    else
                    {
                        try
                        {
                            data.OrganisationBranchDetailId = _context.OrganisationBranchDetails.FirstOrDefault(x => x.Name == OrganisationBranchDetailName).Id;
                        }
                        catch (Exception ex) { data.OrganisationBranchDetailId = 0; }
                    }
                    NotifyStateChanged();
                }
            }
        }

        private string _CityName;
        public string CityName
        {
            get { return _CityName; }
            set
            {
                if (_CityName != value)
                {
                    _CityName = value;
                    if (string.IsNullOrWhiteSpace(CityName))
                    {
                        data.CityId = 0;
                    }
                    else
                    {
                        try
                        {
                            data.CityId = _context.Cities.FirstOrDefault(x => x.Name == CityName).Id;
                        }
                        catch (Exception ex) { data.CityId = 0; }
                    }
                    if (data.CityId == 0)
                    {
                        StateName = "";
                        CountryName = "";
                    }
                    else
                    {
                        var d = _context.Cities.Where(x => x.Id == data.CityId).Select(x => new { StateName = x.State.Name, CountryName = x.State.Country.Name }).FirstOrDefault();
                        if (d != null)
                        {
                            StateName = d.StateName;
                            CountryName = d.CountryName;
                        }
                        else
                        {
                            StateName = "";
                            CountryName = "";
                        }
                    }
                    NotifyStateChanged();
                }
            }
        }

        public string StateName { get; set; }
        public string CountryName { get; set; }
        public override void NewForm()
        {
            base.NewForm();
            OrganisationBranchDetailName = "";
            BankCode = "";
            BankName = "";
            CityName = "";
            StateName = "";
            CountryName = "";
                        
            NotifyStateChanged();
        }
        public override void EditForm(BankBranch d)
        {
            base.EditForm(d);
            OrganisationBranchDetailName = d.OrganisationBranchDetail.Name;
            BankCode = d.Bank.Code;
            BankName = d.Bank.Name;
            CityName = d.City.Name;
            StateName = d.City.State.Name;
            CountryName = d.City.State.Country.Name;

            NotifyStateChanged();
        }
    }
}
