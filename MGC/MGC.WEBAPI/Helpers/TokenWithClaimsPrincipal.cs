﻿using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MGC.WEBAPI.Helpers
{
    public sealed class TokenWithClaimsPrincipal
    {
        public string AccessToken { get; internal set; }

        public ClaimsPrincipal ClaimsPrincipal { get; internal set; }

        public AuthenticationProperties AuthProperties { get; internal set; }
    }
}
