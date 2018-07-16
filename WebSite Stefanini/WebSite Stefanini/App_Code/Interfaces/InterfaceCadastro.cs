using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de InterfaceCadastro
/// </summary>
public interface InterfaceCadastro
{
    int cadastrarUsuario(Usuario user, Login login, Endereco endereco);

    bool validarLogin(string login);

    Endereco checarCep(string cep);
}