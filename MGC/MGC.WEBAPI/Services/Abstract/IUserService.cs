using MGC.CCC;
using MGC.WEBAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MGC.WEBAPI.Services.Abstract
{
    public interface IUserService
    {
        CResult<string> Authenticate(UserCredentials userCredentials);
    }
}
