using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServicoCorreio;

public partial class View_MenuCadastro : System.Web.UI.Page
{
    InterfaceCadastro cadastro;
    
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void ValidarCEPBtn_Click(object sender, EventArgs e)
    {
        cadastro = new Cadastro();
        // var resultadoCep = cadastro.checarCep(CepText.Text);
        Endereco resultadoCep = cadastro.checarCep(CepText.Text);

        if (resultadoCep.Cep != null)
        {
            CepText.BackColor = System.Drawing.Color.White;
            LogradouroText.Text = resultadoCep.Logradouro;
            ComplementoText.Text = resultadoCep.Complemento;
            BairroText.Text = resultadoCep.Bairro;
            CidadeText.Text = resultadoCep.Cidade;
            UFText.Text = resultadoCep.UF;
        }
        else
        {
            CepText.BackColor = System.Drawing.Color.Pink;
        }

    }

    protected void ValidarLoginBtn_Click(object sender, EventArgs e)
    {
        cadastro = new Cadastro();
        if (cadastro.validarLogin(LoginText.Text))
        {
            LoginText.BackColor = System.Drawing.Color.LightGreen;
            CadastrarBTN.Visible = true;

        }
        else
        {
            LoginText.BackColor = System.Drawing.Color.Pink;
            CadastrarBTN.Visible = false;
        }
    }

    protected void CadastrarBTN_Click(object sender, EventArgs e)
    {
        cadastro = new Cadastro();
        if (cadastro.validarLogin(LoginText.Text) && SenhaText.Text != "")
        {
            DateTime dataout;
            if(DateTime.TryParse(NascimentoText.Text, out dataout))
            {
                Usuario user = new Usuario(NomeText.Text, GeneroList.Text, DateTime.Parse(NascimentoText.Text));

                Login login = new Login(LoginText.Text, SenhaText.Text);

                Endereco end = new Endereco(CepText.Text, LogradouroText.Text, BairroText.Text, CidadeText.Text, UFText.Text);
                end.Complemento = ComplementoText.Text;

                if (cadastro.cadastrarUsuario(user, login, end) == 1)
                {
                    ConfirmacaoText.Text = "Cadastro realizado com sucesso";
                    ConfirmacaoText.Visible = true;

                    System.Threading.Thread.Sleep(2000);
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    ConfirmacaoText.Text = "Erro no cadastro, tente novamente!";
                    ConfirmacaoText.Visible = true;
                }
            }
            else
            {
                ConfirmacaoText.Text = "Erro no cadastro, Data de Nascimento Invalida!";
                ConfirmacaoText.Visible = true;
            }

        }
        else
        {
            ConfirmacaoText.Text = "Login inválido, adicione um LOGIN válido!";
            ConfirmacaoText.Visible = true;
        }
    }
}