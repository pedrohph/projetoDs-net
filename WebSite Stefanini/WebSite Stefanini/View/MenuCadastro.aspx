<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MenuCadastro.aspx.cs" Inherits="View_MenuCadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="Panel1" runat="server" Height="354px" Width="50%">
            <h1>Cadastro</h1>
            Nome:<asp:TextBox ID="NomeText" runat="server" ToolTip="Digite seu nome" Width="100%"></asp:TextBox>
            <br />
            <br />
            Gênero:
            <asp:DropDownList ID="GeneroList" runat="server">
                <asp:ListItem>Masculino</asp:ListItem>
                <asp:ListItem>Feminino</asp:ListItem>
                <asp:ListItem>Outros</asp:ListItem>
            </asp:DropDownList>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Data de Nascimento:
            <asp:TextBox ID="NascimentoText" runat="server" TextMode="Date"></asp:TextBox>
                
            <br />
            <br />
            CEP:
            <asp:TextBox ID="CepText" runat="server" MaxLength="8"></asp:TextBox>
            <asp:Button ID="ValidarCEPBtn" runat="server" Text="Validar" OnClick="ValidarCEPBtn_Click" />
            <br />
            <br />
            Logradouro: 
            <asp:TextBox ID="LogradouroText" runat="server" Width="100%"></asp:TextBox>
            <br />
            <br />
            Complemento:
            <asp:TextBox ID="ComplementoText" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Bairro:
            <asp:TextBox ID="BairroText" runat="server"></asp:TextBox>
            <br />
            <br />
            Cidade:
            <asp:TextBox ID="CidadeText" runat="server"></asp:TextBox>
            UF:
            <asp:TextBox ID="UFText" runat="server" MaxLength="2" Width="29px"></asp:TextBox>
            <br />
            <br />
            <br />
            Login:
            <asp:TextBox ID="LoginText" runat="server" ToolTip="Digite seu login"></asp:TextBox>
            <asp:Button ID="ValidarLoginBtn" runat="server" Text="Validar" OnClick="ValidarLoginBtn_Click" />
            <br />
            <br />
            Senha:

            <asp:TextBox ID="SenhaText" runat="server" TextMode="Password" ToolTip="Digite sua senha"></asp:TextBox>

            <asp:Button ID="CadastrarBTN" runat="server" Text="Cadastrar" Visible="False" OnClick="CadastrarBTN_Click" />

            <asp:Label ID="ConfirmacaoText" runat="server" Text="Cadastro confirmado" Visible="False"></asp:Label>

        </asp:Panel>
    </form>
</body>
</html>
