using MGC.CCC;
using MGC.DAL.Abstract.MComputer;
using MGC.DAL.Concrete.EFCore;
using MGC.ENTITY.MProducts.MComputer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MGC.DAL.Concrete.MComputer
{
    public class ComputerDal : Repository<Computer>, IComputerDal
    {
    }
}
