using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApiStefanini.Controllers
{
    [RoutePrefix("Cadastro")]
    public class CadastroController : ApiController
    {
        ProjetoStefaniniEntities entidades = new ProjetoStefaniniEntities();

        [Route("Cadastrar")]
        [HttpPost]
        public int cadastrar([FromBody] Usuario usuario, Endereco endereco, Login login)
        {
            if (validarCadastro(login.Login1))
            {
                if (entidades.InsertEndereco(endereco.Cep, endereco.Logradouro, endereco.Bairro, endereco.Cidade, endereco.UF, endereco.Complemento) == 1)
                {
                    if (entidades.InsertLogin(login.Login1, login.Senha) == 1)
                    {
                        return entidades.InsertUsuario(usuario.Nome, usuario.Nascimento, usuario.Genero, endereco.Cep, login.Login1);
                    }
                    return 0;
                }
                return 0;

            }
            return -1;
        }

        public bool validarCadastro(string login)
        {
            if (login.Length <= 2)
            {
                return false;
            }
            return (!entidades.SelectLoginFromLogin(login).Any<SelectLoginFromLogin_Result>());
        }
    }
}