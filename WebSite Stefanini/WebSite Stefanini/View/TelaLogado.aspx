<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TelaLogado.aspx.cs" Inherits="View_TelaLogado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <%@ PreviousPageType VirtualPath="Default.aspx" %> 
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" OnInit="Panel1_Init">
                Nome:
                <asp:TextBox ID="NomeText" runat="server" Enabled="False"></asp:TextBox>
                <br />
                Data de Nascimento:<asp:TextBox ID="NascimentoText" runat="server" Enabled="False"></asp:TextBox>
                <br />
                Gênero:<asp:TextBox ID="GeneroText" runat="server" Enabled="False"></asp:TextBox>
                <br />
                <br />
                Cep:<asp:TextBox ID="CepText" runat="server" Enabled="False"></asp:TextBox>
                <br />
                Logradouro:<asp:TextBox ID="LogradouroText" runat="server" Enabled="False"></asp:TextBox>
                <br />
                Bairro:<asp:TextBox ID="BairroText" runat="server" Enabled="False"></asp:TextBox>
                <br />
                Complemento:<asp:TextBox ID="ComplementoText" runat="server" Enabled="False"></asp:TextBox>
                <br />
                Cidade:<asp:TextBox ID="CidadeText" runat="server" Enabled="False"></asp:TextBox>
                <br />
                UF:<asp:TextBox ID="UFText" runat="server" Enabled="False"></asp:TextBox>
                <br />
                <asp:Button ID="DeleteBtn" runat="server" OnClick="DeleteBtn_Click" Text="Deletar Conta" />
                <asp:Button ID="DeslogarBtn" runat="server" OnClick="DeslogarBtn_Click" Text="Deslogar" />
                <asp:Button ID="Editar" runat="server" OnClick="Editar_Click" Text="Editar" />
            </asp:Panel>
        </div>
        
    </form>
</body>
</html>
