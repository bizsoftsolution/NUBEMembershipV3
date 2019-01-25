using NUBE.BLL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUBE.DAL;
using Microsoft.EntityFrameworkCore;

namespace NUBE.BLL.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {

        protected readonly NUBEMembershipDBContext _context;
        public Repository(NUBEMembershipDBContext context)
        {
            _context = context;
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
    }
}
