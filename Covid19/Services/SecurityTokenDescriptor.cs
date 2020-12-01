using System;

namespace Covid19.Services
{
    internal class SecurityTokenDescriptor
    {
        public object Subject { get; set; }
        public DateTime Expires { get; set; }
        public object SigningCredentials { get; set; }
    }
}