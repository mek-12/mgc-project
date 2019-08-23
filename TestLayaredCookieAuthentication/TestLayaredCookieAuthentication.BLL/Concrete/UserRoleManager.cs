using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TestLayaredCookieAuthentication.BLL.Abstract;
using TestLayaredCookieAuthentication.CrossCuttingConcerns;
using TestLayaredCookieAuthentication.ENTITIES.Identity;

namespace TestLayaredCookieAuthentication.BLL.Concrete
{
    public class UserRoleManager : BaseManager<UserRole>, IUserRoleManager, IDisposable
    {

        public UserRoleManager() : base () { }

        // Flag: Has Dispose already been called?
        bool disposed = false;
        // Instantiate a SafeHandle instance.
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                // Free any other managed objects here.
                //
            }

            disposed = true;
        }
    }
}
