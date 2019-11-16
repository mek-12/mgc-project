﻿using MGC.BLL.Abstract.MIdentity;
using MGC.ENTITY.Identity;
using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.InteropServices;

namespace MGC.BLL.Concrete.MIdentity
{
    public class RoleManager : BaseManager<ApplicationRole>, IRoleManager, IDisposable
    {
        public RoleManager() : base() { }
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
            }

            disposed = true;
        }
    }
}