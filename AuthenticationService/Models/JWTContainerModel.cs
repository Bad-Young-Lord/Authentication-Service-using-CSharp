﻿using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;

namespace AuthenticationService.Models
{
    public class JWTContainerModel : IAuthContainerModel
    {
        #region Public Methods
        public int ExpireMinutes { get; set; } = 10080;
        public string SecretKey { get; set; } = "TW9zaGVFcmV6UHJpdmF0ZUtleQ==";
        public string SecurityAlgorithm { get; set; } = SecurityAlgorithms.HmacSha256Signature;

        public Claim[] Claims { get; set; }
        #endregion
    }
}
