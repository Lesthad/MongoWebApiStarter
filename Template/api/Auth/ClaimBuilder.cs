﻿using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace MongoWebApiStarter.Api.Auth
{
    public class ClaimBuilder
    {
        private readonly HashSet<Claim> claims = new HashSet<Claim>();

        /// <summary>
        /// Adds a new claim to the builder
        /// </summary>
        /// <param name="claimType">Claim type to use</param>
        /// <param name="claimValue">Claim value to use</param>
        /// <returns></returns>
        public ClaimBuilder WithClaim(string claimType, string claimValue)
        {
            claims.Add(new Claim(claimType, claimValue));
            return this;
        }

        public Claim[] GetClaims()
        {
            return claims.ToArray();
        }
    }
}
