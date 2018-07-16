using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de InterfaceTelaLogado
/// </summary>
public interface InterfaceTelaLogado
{
    Login preencherLogin(int idLogin);
    Usuario preencherUsuario(string login);
    Endereco preencherEndereco(int id);
    void deletarConta(string login);
    int alterarDados(Usuario user, Endereco endereco, string cepAntigo, string login);
}