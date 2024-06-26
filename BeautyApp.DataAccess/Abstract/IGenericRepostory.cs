using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BeautyApp.DataAccess.Abstract
{
    public interface IGenericRepostory<T> where T : class
    {
        List<T> GetList();

        void Create(T entity);

        void Update(T entity);

        void Delete(int id);

        T GetByFilter(Expression<Func<T, bool>> predicate);

        T GetById(int id);

        int Count();

        int FilteredCount(Expression<Func<T, bool>> predicate);

        List<T> GetFilteredList(Expression<Func<T, bool>> predicate);
    }
}
