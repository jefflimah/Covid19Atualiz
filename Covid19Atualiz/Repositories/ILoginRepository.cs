using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Covid19Atualiz.Models.Login;

namespace Covid19Atualiz.Repositories
{
    public class ILoginRepository
    {
        public Login GetLogin(Login login);
    }
}
