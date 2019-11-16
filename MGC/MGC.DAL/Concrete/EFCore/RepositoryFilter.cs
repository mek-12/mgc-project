using MGC.DAL.Abstract;
using MGC.DAL.Concrete.EFCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MGC.DAL.Concrete.EFCore
{
    public class RepositoryFilter<TFilter> : IRepositoryFilter where TFilter: class
    {
        public MgcContext context;
        public DbSet<TFilter> dbset;

        public RepositoryFilter()
        {
            context = new MgcContext();
            dbset = context.Set<TFilter>();
        }

        public object GetAllAsList()
        {
            return dbset.ToList();
        }
    }
}
