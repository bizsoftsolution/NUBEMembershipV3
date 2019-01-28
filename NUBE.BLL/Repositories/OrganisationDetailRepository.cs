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

        public void GetOrganisationDetail()
        {
            var d = _context.OrganisationDetails.Include(x=> x.City).FirstOrDefault();
            if (d == null)
            {
                NewForm();
                CityName = "";
            }
            else
            {
                EditForm(d);
                CityName = d.City.Name;
            }
            NotifyStateChanged();
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
    }
}
