<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Examples.aspx.cs" Inherits="ClassSample.Pages.Examples" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <asp:Label ID="lblTitle" runat="server" Text="Titulo"></asp:Label>
        <asp:BulletedList ID="bl" runat="server">
            <asp:ListItem Text="Antioquia" Value="Antioquia" />
            <asp:ListItem Text="Cundinamarca" Value="Cundinamarca" />
            <asp:ListItem Text="Meta" Value="Meta" />
        </asp:BulletedList>
        <br />
        <div>
            <asp:Button ID="alert" runat="server" Text="Alerta" />
        </div>
        <br />
        <div>
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" SelectedDate="2018-11-01" ToolTip="Calendario de prueba" >
                
            </asp:Calendar>
            <asp:Label ID="lblCalendar" runat="server"></asp:Label>
        </div>
        <br />
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Azul</asp:ListItem>
                <asp:ListItem>Verde</asp:ListItem>
                <asp:ListItem>Rojo</asp:ListItem>
            </asp:DropDownList>
            
        </div>
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Activo" />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="GridDataSource">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Codigo" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="NombreCiudad" HeaderText="Nombre" SortExpression="NombreCiudad" />
            <asp:BoundField DataField="IdDepartamento" HeaderText="Departamento" SortExpression="IdDepartamento" />
        </Columns>

    </asp:GridView>
        <asp:SqlDataSource ID="GridDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:DBCursosConnectionString %>" SelectCommand="SELECT * FROM [Ciudad] WHERE IdDepartamento=1 "></asp:SqlDataSource>
    </form>
    <script src="../Scripts/buttonScript.js"></script>
</body>  
</html>
