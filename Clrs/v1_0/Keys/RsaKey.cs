﻿using System.Security.Cryptography;

namespace OpenCredentialPublisher.Credentials.Clrs.v1_0.Keys
{
    /// <summary>
    /// </summary>
    public class RsaKey
    {
        /// <summary>
        /// </summary>
        public string KeyId { get; set; }

        /// <summary>
        /// </summary>
        public string IssuerId { get; set; }

        /// <summary>
        /// </summary>
        public RSAParameters Parameters { get; set; }
    }
}
