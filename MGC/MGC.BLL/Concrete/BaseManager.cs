using MGC.BLL.Abstract;
using MGC.CCC;
using MGC.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MGC.BLL.Concrete
{
    public class BaseManager<T> : IBaseManager<T> where T : class
    {
        private IRepository<T> repository;

        public BaseManager()
        {
            repository = GeneratorRepository<T>.GetRepositoryEFCore();
        }

        public CResult<T> Add(T entity)
        {
            try
            {
                return repository.Add(entity);
            }
            catch (Exception ex)
            {
                return new CResult<T>() { Message = ex.Message, IsSucceeded = false, Model = entity };
            }
        }

        public async Task<CResult<T>> AddAsync(T entity)
        {
            try
            {
                var result = await repository.AddAsync(entity);
                return result;
            }
            catch (Exception ex)
            {
                return new CResult<T>() { Message = ex.Message, IsSucceeded = false, Model = entity };
            }
        }

        public CResult<T> Delete(object Id)
        {
            try
            {
                var entity = repository.Get(Id);
                return repository.Delete(entity.Model);
            }
            catch (Exception ex)
            {
                return new CResult<T>() { IsSucceeded = false, Message = ex.Message, Model = null };
            }
        }

        public CResult<T> DeleteWithCondition(Func<T, bool> condition)
        {
            try
            {
                var entity = repository.GetWithCondition(condition);
                return repository.Delete(entity.Model);
            }
            catch (Exception ex)
            {
                return new CResult<T>() { IsSucceeded = false, Message = "Model: " + typeof(T).Name + " " + ex.Message };
            }
        }

        public CResult<T> Get(object Id)
        {
            try
            {
                return repository.Get(Id);
            }
            catch (Exception ex)
            {
                var message = typeof(T).Name + " " + ex.Message;
                return new CResult<T>() { IsSucceeded = false, Model = null, Message = message };
            }
        }

        public CResult<IList<T>> GetAll()
        {
            try
            {
                var list = repository.GetAll().ToList();
                if (list == null)
                    return new CResult<IList<T>>() { IsSucceeded = false, Model = null, Message = "List is null" };
                return new CResult<IList<T>>() { IsSucceeded = true, Model = list, Message = "get list successful" };
            }
            catch(Exception ex)
            {
                return new CResult<IList<T>>() { IsSucceeded = false, Model = null, Message = typeof(T).Name + " " + ex.Message };
            }
        }

        public CResult<IList<T>> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            try
            {
                return repository.GetAllIncluding(includeProperties);
            }
            catch (Exception ex)
            {
                var message = typeof(T).Name + " " + ex.Message;
                return new CResult<IList<T>>() { IsSucceeded = false, Message = message, Model = null };
            }
        }

        public Task<List<T>> GetAllIncludingAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public CResult<T> GetIncluding(Expression<Func<bool, T>> expression, params Expression<Func<T, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public CResult<IList<T>> GetListWithCondition(Func<T, bool> condition)
        {
            throw new NotImplementedException();
        }

        public CResult<T> GetWithCondition(Func<T, bool> condition)
        {
            try
            {
                return repository.GetWithCondition(condition);
            }
            catch (Exception ex)
            {
                var message = typeof(T).Name + " " + ex.Message;
                return new CResult<T>() { Message = message, IsSucceeded = true, Model = null };
            }
        }

        public CResult<T> Update(T obj)
        {
            throw new NotImplementedException();
        }

        public Task<CResult<T>> UpdateAsync(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
