using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestLayaredCookieAuthentication.CrossCuttingConcerns;
using TestLayaredCookieAuthentication.DAL.Abstract;
using TestLayaredCookieAuthentication.DAL.Concrete.EFCodeFirst;

namespace TestLayaredCookieAuthentication.DAL.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private TestContextEFCF _context = null;

        private DbSet<T> dbset;

        public Repository()
        {
            _context = new TestContextEFCF();
            dbset = _context.Set<T>();
        }

        public CResult<T> Add(T obj)
        {
            try
            {
                dbset.Add(obj);
                _context.SaveChanges();

                return new CResult<T>() { IsSucceeded = true, Description = "Kayıt işlemi başarılı.", Object = obj };
            }
            catch (Exception ex)
            {
                return new CResult<T> { IsSucceeded = false, Description = ex.Message, Object = obj };
            }
        }

        public async Task<CResult<T>> AddAsync(T obj)
        {
            try
            {
                dbset.Add(obj);
                await _context.SaveChangesAsync();

                return new CResult<T>() { IsSucceeded = true, Description = "Kayıt işlemi başarılı.", Object = obj };
            }
            catch (Exception ex)
            {
                return new CResult<T>() { Description = ex.Message, Object = obj, IsSucceeded = false };
            }
        }
        // Delete Methods *****************************
        public CResult<string> Delete(object Id)
        {
            try
            {
                dbset.Remove(dbset.Find(Id));
                _context.SaveChanges();

                return new CResult<string>() { Description = "Silme işlemi başarılı", IsSucceeded = true };

            }
            catch (Exception ex)
            {
                return new CResult<string>() { Description= "Silme işlemi başarısız: " + ex.Message, IsSucceeded = true};
            }
        }

        public CResult<T> DeleteWithCondition(Func<T, bool> condition)
        {
            try
            {
                IQueryable<T> query = dbset;
                var obj = query.Where(condition).SingleOrDefault();

                if(obj == null)
                {
                    return new CResult<T>() { Data = condition.ToString(), Object = null, Description = "Silme işleminde hata. Belirtilen şartlara uygun bir nesne bulunamadı.", IsSucceeded = false};
                }
                dbset.Remove(obj);
                _context.SaveChanges();
                return new CResult<T>() {Data = condition.ToString(), Object = obj, Description = "Silme işlemi başarılı.", IsSucceeded = true };
            }
            catch (Exception ex)
            {
                return new CResult<T>() { Description = "Beklenmedik hata: " + ex.Message, IsSucceeded = false };
            }
        }
        // End Delete Methods ****************************
        public T Get(object Id)
        {
            try
            {
                T obj = dbset.Find(Id);
                return obj;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public T GetWithCondition(Func<T,bool> condition)
        {
            try
            {
                IQueryable<T> query;
                query = dbset;

                var obj = query.Where(condition).SingleOrDefault();

                return obj;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public IQueryable<T> GetAll()
        {
            try
            {
                return dbset;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            try
            {
                IQueryable<T> query = dbset;
                foreach (var item in includeProperties)
                {
                    query = query.Include(item);
                }
                return query;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<List<T>> GetAllIncludingAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            try
            {
                IQueryable<T> query = dbset;
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }

                return await query.AsNoTracking().ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public T GetIncluding(Expression<Func<bool, T>> expression, params Expression<Func<T, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public List<T> GetMyList(params Func<T, bool>[] conditions)
        {
            IQueryable<T> query = dbset;

            foreach (var condition in conditions)
            {
                query = query.Where(condition).AsQueryable();
            }
            List<T> list = query.ToList();
            return list;
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
