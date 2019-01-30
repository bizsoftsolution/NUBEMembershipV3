using NUBE.BLL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUBE.DAL;
using Microsoft.EntityFrameworkCore;
using NUBE.Common;

namespace NUBE.BLL.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {

        protected readonly NUBEMembershipDBContext _context;
        public Repository(NUBEMembershipDBContext context)
        {
            _context = context;
            MsgData.OnChange += NotifyStateChanged;
        }
        protected void Save() => _context.SaveChanges();

        public bool Create(T entity)
        {
            try
            {
                if (IsValid(entity))
                {
                    _context.Add(entity);
                    Save();
                    return true;
                }
            }
            catch(Exception ex)
            {

            }           
            return false;
        }
        public bool Update(T entity)
        {
            try
            {
                if (IsValid(entity))
                {
                    _context.Entry(entity).State = EntityState.Modified;

                    Save();
                    return true;
                }
            }catch(Exception ex)
            {

            }
            return false;
        }
        public bool Delete(T entity)
        {
            try
            {
                if (CanDelete(entity))
                {
                    _context.Remove(entity);

                    Save();
                    return true;
                }
            }catch(Exception ex)
            {

            }
            return false;
        }
        
        
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        

        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public int Count()
        {
            return _context.Set<T>().Count();
        }
        public int Count(Func<T, Boolean> predicate)
        {
            return _context.Set<T>().Where(predicate).Count();
        }

        public bool Any(Func<T, bool> predicate)
        {
            return _context.Set<T>().Any(predicate);
        }

        public bool Any()
        {
            return _context.Set<T>().Any();
        }


        public virtual int IdByCode(string Code)
        {
            return 0;
        }

        public virtual bool IsValidCode(T entity)
        {
            return false;
        }

        public virtual bool ExistCode(T entity)
        {
            return false;
        }

        public virtual int IdByName(string name)
        {
            return 0;
        }

        public virtual bool IsValidName(T entity)
        {
            return false;
        }

        public virtual bool ExistName(T entity)
        {
            return false;
        }
        public virtual void Reload(T entity)
        {
            _context.Entry(entity).Reload();
        }
        public virtual bool IsValid(T entity)
        {
            return false;
        }
        public virtual bool CanDelete(T entity)
        {
            return false;
        }


        #region Form

        public event Action OnChange;
        public void NotifyStateChanged()
        {
            OnChange?.Invoke();
        }        
        public string SearchText { get; set; } = "";
        public virtual IEnumerable<T> ToList
        {
            get
            {
                return _context.Set<T>();
            }            
        }
        public virtual T data { get; set; }
        public virtual string FormTile { get; set; } = "";
        public bool IsShowForm { get; set; } = false;

        public void ShowForm()
        {
            IsShowForm = true;
            NotifyStateChanged();
        }
        public void HideForm()
        {
            IsShowForm = false;
            NotifyStateChanged();
        }
        public virtual void NewForm()
        {
            data = (T)Activator.CreateInstance(typeof(T));
            ShowForm();
        }
        public virtual void EditForm(T d)
        {
            data = d;
            ShowForm();
        }
        public virtual void CancelForm()
        {
            if ((int)data.GetType().GetProperty("Id").GetValue(data) != 0) Reload(data);
            HideForm();
        }

        public MessageBox MsgData { get; set; } = new MessageBox();
        public virtual void SaveForm()
        {


            if (IsValid(data))
            {
                HideForm();
                if ((int)data.GetType().GetProperty("Id").GetValue(data) == 0)
                {
                    if (Create(data))
                    {
                        MsgData.ShowMessage(FormTile, "Created");
                    }
                    else
                    {
                        MsgData.ShowMessage(FormTile, "Not Created");
                    }
                }
                else
                {
                    if (Update(data))
                    {
                        MsgData.ShowMessage(FormTile, "Updated");
                    }
                    else
                    {
                        MsgData.ShowMessage(FormTile, "Not Updated");
                    }
                }
            }
            else
            {

            }

        }
        public virtual void DeleteForm(T d)
        {
            if (!CanDelete(d))
            {
                MsgData.ShowMessage(FormTile, "It can not Delete. It used to some one");
            }
            else
            {
                MsgData.ShowMessage(FormTile, "Are you delete this?", () =>
                {
                    MsgData.HideMessage();
                    if (Delete(d))
                    {
                        MsgData.ShowMessage(FormTile, "Deleted");
                    }
                    else
                    {
                        MsgData.ShowMessage(FormTile, "not Deleted");
                    }
                    return true;
                });
            }

        }
        #endregion
    }
}
