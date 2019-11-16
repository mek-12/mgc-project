using MGC.DAL.Abstract;
using MGC.ENTITY.MProducts.MComputer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MGC.BLL.Concrete.MComputer
{
    public class ComputerFilterManager
    {
        const string MGC_BLL = "MGC.ENTITY";

        private IRepository<ComputerFilter> repository;

        public ComputerFilterManager()
        {
            repository = GeneratorRepository<ComputerFilter>.GetRepositoryEFCore();
        }

        public object GetListFilter()
        {
            IList<object> objlist = new List<object>();
            IList<ComputerFilter> list = repository.GetAll().ToList();

            

            foreach (var item in list)
            {
                try
                {
                    Type type = Type.GetType(item.TableType + ',' + MGC_BLL);
                    var repositoryFilter = (IRepositoryFilter)GeneratorRepository.GetRepositoryFromEntityType(type);

                    var listFiter = repositoryFilter.GetAllAsList();

                    objlist.Add(listFiter);
                }
                catch (Exception ex)
                {
                    return ex;
                }
                
            }

            return objlist;
        }
    }
}
