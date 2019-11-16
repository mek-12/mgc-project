using MGC.CCC;
using MGC.DAL.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MGC.DAL.Concrete.EFCore
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private MgcContext context;
        private DbSet<T> dbset;

        public Repository()
        {
            context = new MgcContext();
            dbset = context.Set<T>();
        }

        public CResult<T> Add(T obj)
        {
            try
            {
                dbset.Add(obj);
                context.SaveChanges();

                return new CResult<T>() { Message = typeof(T).FullName + " insert successful", Model = obj, IsSucceeded = true };
            }
            catch (Exception ex)
            {
                return new CResult<T>() { Message = ex.Message, IsSucceeded = false, Model = null };
            }
        }

        public async Task<CResult<T>> AddAsync(T obj)
        {
            try
            {
                await dbset.AddAsync(obj);
                context.SaveChanges();

                return new CResult<T>() { Message = typeof(T).FullName + "async insert successful", Model = obj, IsSucceeded = true };
            }
            catch (Exception ex)
            {
                return new CResult<T>() { Message = ex.Message, IsSucceeded = false, Model = null };
            }
        }

        public CResult<T> Delete(T entity)
        {
            try
            {
                var result = dbset.Remove(entity);
                if (result.State == EntityState.Deleted)
                {
                    context.SaveChanges();
                    return new CResult<T>() { Message = typeof(T).Name + " delete successfull", Model = entity, IsSucceeded = true };
                }

                return new CResult<T>() { Message = typeof(T).Name + " delete unsuccessfull", Model = entity, IsSucceeded = false };
            }
            catch (Exception ex)
            {
                return new CResult<T>() { Message = typeof(T).Name + " " + ex.Message, Model = entity, IsSucceeded = false };
            }

        }

        public async Task<CResult<T>> DeleteAsync(T entity)
        {
            try
            {
                var result = dbset.Remove(entity);
                if (result.State == EntityState.Deleted)
                {
                    await context.SaveChangesAsync();
                    return new CResult<T>() { Message = typeof(T).Name + " delete successfull", Model = entity, IsSucceeded = true };
                }

                return new CResult<T>() { Message = typeof(T).Name + " delete unsuccessfull", Model = entity, IsSucceeded = false };
            }
            catch (Exception ex)
            {
                return new CResult<T>() { Message = typeof(T).Name + " " + ex.Message, Model = entity, IsSucceeded = false };
            }
        }

        public CResult<T> Get(object Id)
        {
            try
            {
                var entity = dbset.Find(Id);

                return new CResult<T>() { Message = typeof(T).Name + " get successfull", Model = entity, IsSucceeded = true };
            }
            catch (Exception ex)
            {
                var message = typeof(T).Name + " " + ex.Message;
                return new CResult<T>() { Message = message, Model = null, IsSucceeded = false };
            }
        }

        public IQueryable<T> GetAll()
        {
            return dbset;
        }

        public CResult<IList<T>> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            try
            {
                IQueryable<T> query = dbset;

                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }

                return new CResult<IList<T>>() { Message = typeof(T).Name + " get successfull", IsSucceeded = true, Model = query.ToList() };
            }
            catch (Exception ex)
            {
                return new CResult<IList<T>> { Message = typeof(T).Name + " " + ex.Message, IsSucceeded = false, Model = null };
            }
        }

        public CResult<IList<T>> GetAllIncluding(params object[] includeProperties)
        {
            try
            {
                IQueryable<T> query = dbset;

                foreach(var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty.ToString());
                }

                return new CResult<IList<T>>() { IsSucceeded = true, Message = typeof(T).Name + " get successfull", Model = query.ToList() };
            }
            catch (Exception ex)
            {
                var message = typeof(T).Name + " " + ex.Message;
                return new CResult<IList<T>>() { IsSucceeded = false, Message = message , Model = null };
            }
        }

        public async Task<CResult<IList<T>>> GetAllIncludingAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            try
            {
                IQueryable<T> query = dbset;

                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
                var model = await query.ToListAsync();
                return new CResult<IList<T>>() { Message = typeof(T).Name + " get successfull", IsSucceeded = true, Model = model };
            }
            catch (Exception ex)
            {
                return new CResult<IList<T>> { Message = typeof(T).Name + " " + ex.Message, IsSucceeded = false, Model = null };
            }
        }

        public CResult<T> GetIncluding(Expression<Func<bool, T>> expression, params Expression<Func<T, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public CResult<T> GetWithCondition(Func<T, bool> condition)
        {
            try
            {
                var entity = dbset.Where(condition).SingleOrDefault();
                return new CResult<T>() { IsSucceeded = true, Message = typeof(T).Name + " get successfull", Model = entity };
            }
            catch (Exception ex)
            {
                return new CResult<T>() { IsSucceeded = false, Message = typeof(T).Name + " " + ex.Message, Model = null };
            }
        }

        public CResult<IList<T>> GetListWithCondition(Func<T, bool> condition)
        {
            try
            {
                var list = dbset.Where(condition).ToList();
                if (list == null || list.Count == 0)
                    return new CResult<IList<T>>()
                    {
                        Model = null,
                        Message = typeof(T).FullName + "model is null",
                        IsSucceeded = true
                    };

                return new CResult<IList<T>>() { Model = list, Message = typeof(T).FullName + "query successfull", IsSucceeded = true };
            }
            catch (Exception ex)
            {
                return new CResult<IList<T>>()
                {
                    Model = null,
                    Message = ex.Message,
                    IsSucceeded = false
                };
            }
        }

        public CResult<T> Update(T obj)
        {
            try
            {
                var entity = context.Entry(obj);
                entity.State = EntityState.Modified;
                context.SaveChanges();

                return new CResult<T>() { IsSucceeded = true, Model = obj, Message = typeof(T).Name + "Update successfull" };
            }
            catch (Exception ex)
            {
                return new CResult<T>() { IsSucceeded = true, Model = obj, Message = typeof(T).Name + " " + ex.Message };
            }
        }

        public async Task<CResult<T>> UpdateAsync(T obj)
        {
            try
            {
                var entity = context.Entry(obj);
                entity.State = EntityState.Modified;
                await context.SaveChangesAsync();

                return new CResult<T>() { IsSucceeded = true, Model = obj, Message = typeof(T).Name + "Update successfull" };
            }
            catch (Exception ex)
            {
                return new CResult<T>() { IsSucceeded = true, Model = obj, Message = typeof(T).Name + " " + ex.Message };
            }
        }

        
    }
}
