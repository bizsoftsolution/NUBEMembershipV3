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

        private string _countryName;
        public string CountryName
        {
            get { return _countryName; }
            set
            {
                if (_countryName != value)
                {
                    _countryName = value;
                    if (string.IsNullOrWhiteSpace(CountryName))
                    {
                        data.CountryId = 0;
                    }
                    else
                    {                        
                        try
                        {
                            data.CountryId = _context.Countries.FirstOrDefault(x=> x.Name==CountryName).Id;
                        }
                        catch (Exception ex) { data.CountryId = 0; }                        
                    }
                    NotifyStateChanged();
                }
            }
        }

        public override IEnumerable<State> ToList
        {
            get
            {
                try
                {
                    var rv = _context.States.Include(x=> x.Country).Where(x => String.IsNullOrWhiteSpace(SearchText) || (x.Name.ToLower().Contains(SearchText.ToLower()) || x.Country.Name.ToLower().Contains(SearchText.ToLower()) )).ToList();
                    return rv;
                }
                catch (Exception ex)
                {

                }
                return base.ToList;
            }
        }
        public override string FormTile { get; set; } = "State";

        public override void NewForm()
        {
            base.NewForm();
            CountryName = "";
            NotifyStateChanged();
        }
        public override void EditForm(State d)
        {
            base.EditForm(d);
            CountryName = d.Country.Name;
            NotifyStateChanged();
        }

    }
}
