using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de MenuLogado
/// </summary>
public class MenuLogado: InterfaceTelaLogado
{
    ProjetoStefaniniEntities1 conexao;
        
        public MenuLogado()
    {
            conexao = new ProjetoStefaniniEntities1();
        }

    public Login preencherLogin(int idLogin)
    {
        var resultado = conexao.SelectLoginFromId(idLogin);
        var login = resultado.First<SelectLoginFromId_Result>();

        Login retorno = new Login(login.Login, login.Senha);
        retorno.Id = login.Id;

        return retorno;
    }

    public Endereco preencherEndereco(int id)
    {
        var endereco = conexao.SelectEnderecoFromId(id).First<SelectEnderecoFromId_Result>();
        Endereco retorno = new Endereco(endereco.Cep, endereco.Logradouro, endereco.Bairro, endereco.Cidade, endereco.UF);
        retorno.Complemento = endereco.Complemento;
        return retorno;
    }

    public Usuario preencherUsuario(string login)
    {
        var usuario = conexao.SelectUsuarioFromLogin(login).First<SelectUsuarioFromLogin_Result>();
        Usuario retorno = new Usuario(usuario.Nome, usuario.Genero, usuario.Nascimento);
        retorno.Endereco_Id = usuario.Endereco_Id;
        return retorno;
    }

    public void deletarConta(string login)
    { 
        conexao.DeleteUsuario(login);
        conexao.DeleteLogin(login);

    }

    public int alterarDados(Usuario user, Endereco endereco, string cepAntigo, string login)
    {
       
        conexao.UpdateEndereco(cepAntigo, endereco.Cep, endereco.Logradouro, endereco.Bairro, endereco.Cidade, endereco.UF, endereco.Complemento);
        return conexao.UpdateUsuario(login, user.Nome, user.Nascimento, user.Genero, endereco.Cep);



    }
}