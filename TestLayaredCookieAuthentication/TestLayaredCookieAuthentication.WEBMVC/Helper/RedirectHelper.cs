using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestLayaredCookieAuthentication.WEBMVC.Models;

namespace TestLayaredCookieAuthentication.WEBMVC.Helper
{
    internal sealed class RedirectHelper : IDisposable
    {
        
        internal RedirectRouteResult RedirectAreaResult(string userRole)
        {
            try
            {
                var redirect = new RedirectRouteResult() { Controller = "Home", Action = "Index" };

                switch (userRole)
                {
                    case "ADMIN":
                        redirect.Area = "admin";
                        break;
                    case "CUSTOMER":
                        redirect.Area = "Customer";
                        break;
                    case "TRADER":
                        redirect.Area = "TradeCompany";
                        break;
                    case "TRANSPORT":
                        redirect.Area = "TransportCompany";
                        break;

                    default:
                        break;
                }

                return redirect;
            }
            catch 
            {
                return null;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
