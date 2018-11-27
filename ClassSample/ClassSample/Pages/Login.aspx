<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ClassSample.Pages.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Usuario">

            </asp:Label>
            <asp:TextBox ID="user" runat="server"></asp:TextBox>
              <br />
            <asp:Label ID="Label2" runat="server" Text="Contrasena">

            </asp:Label>
          
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" OnClick="Button1_Click" runat="server" Text="Iniciar sesion" />
        </div>
    </form>
</body>
</html>
