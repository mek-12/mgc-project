using MGC.DAL.Concrete;
using MGC.DAL.Concrete.EFCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MGC.DAL.Abstract
{
    public abstract class GeneratorRepository<T> where T : class
    {
        public static IRepository<T> GetRepositoryEFCore()
        {
            return new Repository<T>();
        }

    }
    public abstract class GeneratorRepository
    {
        public static object GetRepositoryFromEntityType(Type entityType)
        {
            Type repositoryType = typeof(RepositoryFilter<>).MakeGenericType(new Type[] { entityType });

            object repository = Activator.CreateInstance(repositoryType);

            return repository;
        }
    }
}
