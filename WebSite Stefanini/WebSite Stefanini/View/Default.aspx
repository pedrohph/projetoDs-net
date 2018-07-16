<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1"  runat="server"  >
       <div>
        <asp:Panel ID="Panel1" style="text-align: right;" runat="server" BackColor="White" Height="197px" Width="390px">
            <asp:TextBox ID="LoginText" runat="server" ToolTip="Digite seu Login" Width="100%" Height="35px"></asp:TextBox>
            <asp:TextBox ID="SenhaText" runat="server" TextMode="Password" ToolTip="Digite sua senha" Width="100%" Height="37px"></asp:TextBox>
            <br /><br /><br /><br />
            <asp:Button ID="Login" runat="server" Text="Login" OnClick="Login_Click" />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/View/MenuCadastro.aspx" Target="_self">Ou cadastre-se clicando aqui</asp:HyperLink>
        </asp:Panel>
        
        </div>
    </form>
</body>
</html>
