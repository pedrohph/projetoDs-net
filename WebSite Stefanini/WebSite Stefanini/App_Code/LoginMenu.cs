using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Login
/// </summary>
public class LoginMenu : InterfaceLogin
{
    ProjetoStefaniniEntities1 conexao;
    public LoginMenu()
    {
        conexao = new ProjetoStefaniniEntities1();
    }

    public int logar(string login, string senha)
    {
        if (conexao.SelectLoginfromLoginAndSenha(login, senha).Any<int?>())
        {
            return conexao.SelectLoginfromLoginAndSenha(login, senha).First<int?>().Value;
        }
        return -1;

    }
}