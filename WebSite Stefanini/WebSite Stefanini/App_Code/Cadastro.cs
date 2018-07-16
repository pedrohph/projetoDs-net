using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServicoCorreio;

/// <summary>
/// Descrição resumida de Cadastro
/// </summary>
public class Cadastro : InterfaceCadastro
{
    ProjetoStefaniniEntities1 conexao;
    public Cadastro()
    {
        conexao = new ProjetoStefaniniEntities1();
    }


    public int cadastrarUsuario(Usuario user, Login login, Endereco endereco)
    {
        if(conexao.InsertLogin(login.Login1, login.Senha) == 1)
        {
            if(conexao.InsertEndereco(endereco.Cep, endereco.Logradouro, endereco.Bairro, endereco.Cidade, endereco.UF, endereco.Complemento) == 1)
            {
                return conexao.InsertUsuario(user.Nome, user.Nascimento, user.Genero, endereco.Cep, login.Login1);
            }
            else { return 0; }
        }
        return 0;
    }

    public bool validarLogin(string login)
    {
        if(login.Length < 3)
        {
            return false;
        }

        int i = conexao.SelectLoginFromLogin(login).Count<SelectLoginFromLogin_Result>();
       
        return (i == 0);
    }

    public Endereco checarCep(string cep)
    {
        AtendeClienteClient servicoCorreio = new AtendeClienteClient();
        Endereco retorno= new Endereco();
        try
        {
            var resultadoCep = servicoCorreio.consultaCEP(cep);

            retorno.Logradouro = resultadoCep.end;
            retorno.Bairro = resultadoCep.bairro;
            retorno.Cidade = resultadoCep.cidade;
            retorno.UF = resultadoCep.uf;
            retorno.Complemento = resultadoCep.complemento;
            retorno.Cep = resultadoCep.cep;
            //Criar entidade com CEP

        }
        catch (System.Exception ex)
        {
        }

        return retorno;
    }
}