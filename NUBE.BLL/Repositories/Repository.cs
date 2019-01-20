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
            _context.Add(entity);

            Save();
            return true;
        }

        public virtual bool Delete(T entity)
        {
            _context.Remove(entity);

            Save();
            return true;
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public bool Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;

            Save();
            return true;
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
    }
}
