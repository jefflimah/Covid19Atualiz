using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        public Login GetLogin(Login login)
        {
            if (login.usuario == "victor" && login.senha == "4455")
            {
                login.id = 1;
                login.grupo = "administrador";
                return login;
            }
            return null;
        }
    }
}
