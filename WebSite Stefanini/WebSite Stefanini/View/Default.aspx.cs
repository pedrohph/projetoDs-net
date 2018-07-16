using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    InterfaceLogin interfaceLogin;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Login_Click(object sender, EventArgs e)
    {
        interfaceLogin = new LoginMenu();

        int index = interfaceLogin.logar(LoginText.Text, SenhaText.Text);
        if (index == -1)
        {
            LoginText.BackColor = System.Drawing.Color.Pink;
            SenhaText.BackColor = System.Drawing.Color.Pink;
        }
        else
        {
            Session["idLogin"] = index;
            Response.Redirect("TelaLogado.aspx");

        }
    }

   
}