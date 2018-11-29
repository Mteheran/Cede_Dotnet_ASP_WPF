<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="Validators.aspx.cs" Inherits="ClassSample.Pages.Challenges.Validators" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <script src="../../Styles/vendor/jquery-3.2.1.min.js"></script>
    <script src="../../Styles/vendor/animsition/animsition.min.js"></script>
    <script src="../../Styles/vendor/bootstrap-4.1/popper.min.js"></script>
    <script src="../../Styles/vendor/bootstrap-4.1/bootstrap.min.js"></script>
    <script src="../../Styles/vendor/wow/wow.min.js"></script>
    <script src="../../Styles/js/main.js"></script>


    <div class="card">      
     <div class="card-header">
        <strong>Validar Usuario y contraseña, cambiar la contraseña a password y validar el correo </strong>
        </div>
     <div class="form-group">         
        <asp:Label class="control-label mb-1" runat="server" text="Usuario"></asp:Label>
        <asp:TextBox class="form-control" ID="txtUser" runat="server"></asp:TextBox>
    </div>
        <div class="form-group">
        <asp:Label class="control-label mb-1" runat="server" text="Password"></asp:Label>
        <asp:TextBox  class="form-control" ID="txtPassword" runat="server"></asp:TextBox>
    </div>
        <div class="form-group">
        <asp:Label class="control-label mb-1" runat="server" text="Correo"></asp:Label>
        <asp:TextBox class="form-control" ID="txtEmail"  runat="server"></asp:TextBox>
    </div>
    <asp:Button ID="btnGuardar" class="btn btn-lg btn-info btn-block" OnClick="btnGuardar_Click" runat="server" Text="Guardar" />
        </div>

</asp:Content>
