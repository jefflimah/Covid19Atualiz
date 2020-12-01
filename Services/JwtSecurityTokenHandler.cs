using System;

namespace Covid19.Services
{
    internal class JwtSecurityTokenHandler
    {
        public JwtSecurityTokenHandler()
        {
        }

        internal string WriteToken(object token)
        {
            throw new NotImplementedException();
        }

        internal object CreateToken(SecurityTokenDescriptor tokenDescriptor)
        {
            throw new NotImplementedException();
        }
    }
}