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

        private string _stateName;
        public string StateName
        {
            get { return _stateName; }
            set
            {
                if (_stateName != value)
                {
                    _stateName = value;
                    if (string.IsNullOrWhiteSpace(StateName))
                    {
                        data.StateId = 0;
                    }
                    else
                    {
                        try
                        {
                            data.StateId = _context.States.FirstOrDefault(x => x.Name == StateName).Id;
                        }
                        catch (Exception ex) { data.StateId = 0; }
                    }
                    NotifyStateChanged();
                }
            }
        }

        public override IEnumerable<City> ToList
        {
            get
            {
                try
                {
                    var rv = _context.Cities.Include(x => x.State).Where(x => String.IsNullOrWhiteSpace(SearchText) || (x.Name.ToLower().Contains(SearchText.ToLower()) || x.State.Name.ToLower().Contains(SearchText.ToLower()))).ToList();
                    return rv;
                }
                catch (Exception ex)
                {

                }
                return base.ToList;
            }
        }
        public override string FormTile { get; set; } = "City";

        public override void NewForm()
        {
            base.NewForm();
            StateName = "";
            NotifyStateChanged();
        }
        public override void EditForm(City d)
        {
            base.EditForm(d);
            StateName = d.State.Name;
            NotifyStateChanged();
        }
    }
}
