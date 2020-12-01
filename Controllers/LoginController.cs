using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.SqlServer.Dac.Model;

namespace Covid19.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private LoginRepository _repository;
        public LoginController()
        {
            _repository = new LoginRepository();
        }


        [AllowAnonymous]
        [HttpPost]
        [Route("autenticacao")]
        public async Task<ActionResult<dynamic>> autenticacao(Login login)
        {
            var usuario = _repository.GetLogin(login);
            if (usuario == null)
                return NotFound(" usuário inválido, verifique os dados digitados");


            var token = TokenService.GenerateToken(usuario);
            login.senha = "";
            return new
            {
                usuario = usuario,
                token = token
            };
        }
    }
}
