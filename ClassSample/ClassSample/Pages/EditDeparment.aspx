<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="EditDeparment.aspx.cs" Inherits="ClassSample.Pages.EditDeparment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <h1>Editando departamento</h1>  
  <asp:Label runat="server" ID="lblID"></asp:Label>
  <asp:Textbox runat="server" ID="txtName"></asp:Textbox>
    <asp:RequiredFieldValidator runat="server" errormessage="Es requerido" ControlToValidate="txtName"></asp:RequiredFieldValidator>
  <asp:Button  runat="server" ID="btnUpdate" Text="Actualizar" OnClick="btnUpdate_Click"   />  
   
</asp:Content>
