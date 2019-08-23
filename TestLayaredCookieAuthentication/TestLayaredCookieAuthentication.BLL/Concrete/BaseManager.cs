using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestLayaredCookieAuthentication.BLL.Abstract;
using TestLayaredCookieAuthentication.CrossCuttingConcerns;
using TestLayaredCookieAuthentication.DAL.Abstract;

namespace TestLayaredCookieAuthentication.BLL.Concrete
{
    public abstract class BaseManager<T> : IBaseManager<T> where T:class
    {
        private IRepository<T> _genericDal;

        protected BaseManager()
        {
            _genericDal = GeneratorRepository<T>.GetRepository();
        }

        

        /// <summary>
        /// Nesne Kayıt Fonksiyonu
        /// </summary>
        /// <param name="entity">nesne</param>
        /// <returns></returns>
        public virtual CResult<T> Add(T entity)
        {
            return _genericDal.Add(entity);
        }
        public virtual async Task<CResult<T>> AddAsync(T entity)
        {
            return await _genericDal.AddAsync(entity);
        }
        /// <summary>
        /// Nesne Silen Fonksiyon
        /// </summary>
        /// <param name="entityId">nesne Id (PK)</param>
        /// <returns></returns>
        public virtual CResult<string> Delete(int entityId)
        {
            return _genericDal.Delete(entityId);
        }
        /// <summary>
        /// Verilen filtre ile uygun nesneyi silen method.
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public virtual CResult<T> DeleteWithCondition(Func<T, bool> condition)
        {
            return _genericDal.DeleteWithCondition(condition);
        }

        /// <summary>
        /// Tek Bir Nesne Getiren Fonksiyon
        /// </summary>
        /// <param name="entityId">nesne Id(PK)</param>
        /// <returns></returns>
        public virtual T Get(int entityId)
        {
            return _genericDal.Get(entityId);
        }
        /// <summary>
        /// Verilen filtre ile nesneyi getir
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public T GetWithCondition(Func<T, bool> condition)
        {
            return _genericDal.GetWithCondition(condition);
        }

        /// <summary>
        /// Tüm nesneleri Getiren Fonksiyon
        /// </summary>
        /// <returns></returns>
        public virtual IQueryable<T> GetAll()
        {
            return _genericDal.GetAll();
        }

        /// <summary>
        /// Tüm nesneleri ve ilişki olduğu nesneleride getiren fonksiyon
        /// </summary>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        public virtual IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            return _genericDal.GetAllIncluding(includeProperties);
        }

        public virtual async Task<List<T>> GetAllIncludingAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            return await _genericDal.GetAllIncludingAsync(includeProperties);
        }

        /// <summary>
        /// Nesne güncelleme fonksiyonu
        /// </summary>
        /// <param name="entity">nesne</param>
        /// <returns></returns>
        public virtual CResult<T> Update(T entity)
        {
            return _genericDal.Update(entity);
        }

        /// <summary>
        /// Nesne güncelleme fonksiyonu asenkron
        /// </summary>
        /// <param name="entity">nesne</param>
        /// <returns></returns>
        public virtual async Task<CResult<T>> UpdateAsync(T entity)
        {
            return await _genericDal.UpdateAsync(entity);
        }
        
        public List<T> GetListWithWhereConditions(params Func<T, bool>[] conditions)
        {
            return _genericDal.GetMyList(conditions);
        }

    }
}
