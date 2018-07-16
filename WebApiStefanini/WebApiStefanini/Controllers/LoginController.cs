using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApiStefanini.Controllers
{
    [RoutePrefix("Login")]
    public class LoginController : ApiController
    {
        ProjetoStefaniniEntities entidades = new ProjetoStefaniniEntities();
        [Route("Logar")]
        public int logar([FromBody] string login, string senha)
        {
            if (entidades.SelectLoginfromLoginAndSenha(login, senha).Any<int?>())
            {
                return entidades.SelectLoginfromLoginAndSenha(login, senha).First<int?>().Value;
            }
            return -1;
        }

    }
}