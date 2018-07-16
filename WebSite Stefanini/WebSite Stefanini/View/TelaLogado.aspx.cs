using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_TelaLogado : System.Web.UI.Page
{
    int idLogin;
    InterfaceTelaLogado conexao;

    Login login;
    Usuario usuario;
    Endereco endereco;
    protected void Page_Load(object sender, EventArgs e)
    {
       

    }



    protected void DeleteBtn_Click(object sender, EventArgs e)
    {
        conexao.deletarConta(login.Login1);
        Response.Redirect("Default.aspx");
        Session.Remove("idLogin");

    }


    protected void DeslogarBtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
        Session.Remove("idLogin");
    }

    protected void Editar_Click(object sender, EventArgs e)
    {
        if (Editar.Text == "Editar")
        {
            NomeText.Enabled = true;
            GeneroText.Enabled = true;
            NascimentoText.Enabled = true;

            CepText.Enabled = true;
            LogradouroText.Enabled = true;
            BairroText.Enabled = true;
            CidadeText.Enabled = true;
            UFText.Enabled = true;
            ComplementoText.Enabled = true;

            Editar.Text = "Atualizar";
        }
        else
        {
            if (DateTime.TryParse((NascimentoText.Text), out DateTime result))
            {
                Usuario novoUser = new Usuario(NomeText.Text, GeneroText.Text, DateTime.Parse(NascimentoText.Text));

                Endereco novoEndereco = new Endereco(CepText.Text, LogradouroText.Text, BairroText.Text, CidadeText.Text, UFText.Text);

                NomeText.Enabled = false;
                GeneroText.Enabled = false;
                NascimentoText.Enabled = false;

                CepText.Enabled = false;
                LogradouroText.Enabled = false;
                BairroText.Enabled = false;
                CidadeText.Enabled = false;
                UFText.Enabled = false;
                ComplementoText.Enabled = false;


                if (conexao.alterarDados(novoUser, novoEndereco, endereco.Cep, login.Login1) == 0)
                {
                    NomeText.BackColor = System.Drawing.Color.Pink;
                }
                else
                {
                    NascimentoText.BackColor = System.Drawing.Color.White;
                }
                Editar.Text = "Editar";
            }
            else
            {
                NascimentoText.BackColor = System.Drawing.Color.Pink;
            }
        }
        
    }

    protected void Panel1_Init(object sender, EventArgs e)
    {
        idLogin = int.Parse(Session["idLogin"].ToString());
        // Session.Remove("idLogin");

        conexao = new MenuLogado();
        login = conexao.preencherLogin(idLogin);
        usuario = conexao.preencherUsuario(login.Login1);
        endereco = conexao.preencherEndereco(usuario.Endereco_Id);

        NomeText.Text = usuario.Nome;
        GeneroText.Text = usuario.Genero;
        NascimentoText.Text = usuario.Nascimento.ToShortDateString();

        CepText.Text = endereco.Cep;
        LogradouroText.Text = endereco.Logradouro;
        BairroText.Text = endereco.Bairro;
        CidadeText.Text = endereco.Cidade;
        UFText.Text = endereco.UF;
        ComplementoText.Text = endereco.Complemento;
    }
}