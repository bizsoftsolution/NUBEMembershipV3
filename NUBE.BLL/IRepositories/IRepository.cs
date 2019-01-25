using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NUBE.BLL.IRepositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        IEnumerable<T> Find(Func<T, bool> predicate);

        T GetById(int id);

        bool Create(T entity);

        bool Update(T entity);

        bool Delete(T entity);
        void Reload(T entity);
        bool IsValid(T entity);
        bool CanDelete(T entity);
        int IdByName(string name);
        bool IsValidName(T entity);
        bool ExistName(T entity);

        int Count();
        int Count(Func<T, bool> predicate);

        bool Any(Func<T, bool> predicate);

        bool Any();
    }
}
