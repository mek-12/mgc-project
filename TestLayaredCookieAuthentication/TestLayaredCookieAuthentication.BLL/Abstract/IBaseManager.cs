using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestLayaredCookieAuthentication.CrossCuttingConcerns;

namespace TestLayaredCookieAuthentication.BLL.Abstract
{
    public interface IBaseManager<T> where T : class
    {
        CResult<T> Add(T entity);

        Task<CResult<T>> AddAsync(T entity);

        CResult<string> Delete(int entityId);

        CResult<T> DeleteWithCondition(Func<T,bool> condition);
        T Get(int entityId);
        T GetWithCondition(Func<T,bool> condition);

        IQueryable<T> GetAll();

        IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties);

        Task<List<T>> GetAllIncludingAsync(params Expression<Func<T, object>>[] includeProperties);

        CResult<T> Update(T entity);

        Task<CResult<T>> UpdateAsync(T entity);

        List<T> GetListWithWhereConditions(params Func<T, bool>[] conditions);

    }
}
