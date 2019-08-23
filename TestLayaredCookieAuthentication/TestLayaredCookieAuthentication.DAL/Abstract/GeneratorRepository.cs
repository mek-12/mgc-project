using System;
using System.Collections.Generic;
using System.Text;
using TestLayaredCookieAuthentication.DAL.Concrete;

namespace TestLayaredCookieAuthentication.DAL.Abstract
{
    public abstract class GeneratorRepository<T> where T : class
    {
        public static IRepository<T> GetRepository()
        {
            return new Repository<T>();
        }
    }
}
