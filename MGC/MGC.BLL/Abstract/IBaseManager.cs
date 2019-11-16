using MGC.CCC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MGC.BLL.Abstract
{
    public interface IBaseManager<T> where T : class
    {
        ///<summary>
        ///Tüm nesneleri al
        ///</summary>
        ///<returns></returns>
        CResult<IList<T>> GetAll();

        /// <summary>
        /// Girilen sorgu (Linq) ifadesine göre filtreleyerek getir. Nesne ile ilişkili diğer nesneleri getir.
        /// </summary>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        CResult<IList<T>> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties);

        /// <summary>
        /// Nesne ve nesne ile ilişkilei olan nesneleri asenkron olarak getir.
        /// </summary>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        Task<List<T>> GetAllIncludingAsync(params Expression<Func<T, object>>[] includeProperties);

        /// <summary>
        /// Tek bir nesneyi ilişkili olduğu nesne ile getir.
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        CResult<T> GetIncluding(Expression<Func<bool, T>> expression, params Expression<Func<T, object>>[] includeProperties);

        /// <summary>
        /// Nesneyi veriler parametreye göre getir
        /// </summary>
        /// <param name="Id">nesne Id</param>
        /// <returns></returns>
        CResult<T> Get(object Id);

        CResult<T> GetWithCondition(Func<T, bool> condition);

        CResult<IList<T>> GetListWithCondition(Func<T, bool> condition);

        /// <summary>
        /// Gönderilen nesneyi kaydet
        /// </summary>
        /// <param name="obj">Nesne</param>
        /// <returns></returns>
        CResult<T> Add(T obj);

        /// <summary>
        /// Gönderilen nesneyi asenkron olarak kaydet
        /// </summary>
        /// <param name="obj">nesne</param>
        /// <returns></returns>
        Task<CResult<T>> AddAsync(T obj);

        /// <summary>
        /// Gönderilen nesneyi güncelle.
        /// </summary>
        /// <param name="obj">Güncellenek Nesne</param>
        /// <returns></returns>
        CResult<T> Update(T obj);

        /// <summary>
        /// Gönderilen nesneyi asenkron olarak sil.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        Task<CResult<T>> UpdateAsync(T obj);

        /// <summary>
        /// Verilen nesne Id sine göre nesneyi sil.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        CResult<T> Delete(object Id);
        /// <summary>
        /// Filtreye(Kurala) göre bul ve sil
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        CResult<T> DeleteWithCondition(Func<T, bool> condition);

    }
}
