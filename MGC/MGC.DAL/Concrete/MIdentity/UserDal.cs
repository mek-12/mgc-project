using MGC.DAL.Abstract.MIdentity;
using MGC.DAL.Concrete.EFCore;
using MGC.ENTITY.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MGC.DAL.Concrete.MIdentity
{
    public class UserDal : Repository<ApplicationUser>, IUserDal
    {
    }
}
