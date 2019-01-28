using NUBE.Common;
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

        #region CUD

        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);

        #endregion

        #region Form

        event Action OnChange;
        void NotifyStateChanged();

        string SearchText { get; set; }
        IEnumerable<T> ToList { get; }
        T data { get; set; }
        string FormTile { get; set; }
        bool IsShowForm { get; set; }

        void ShowForm();
        void HideForm();
        void NewForm();
        void EditForm(T d);
        void CancelForm();
        MessageBox MsgData { get; set; }
        void SaveForm();
        void DeleteForm(T d);

        #endregion
    }
}
