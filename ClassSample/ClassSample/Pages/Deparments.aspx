<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="Deparments.aspx.cs" Inherits="ClassSample.Pages.Deparments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="table-responsive table--no-card m-b-30">
    <asp:GridView ID="GridView1" OnRowDataBound="GridView1_RowDataBound" UseAccessibleHeader="true" class="table table-borderless table-striped table-earning" DataKeyNames="ID"  OnSelectedIndexChanged="GridView1_SelectedIndexChanged" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField HeaderText="Nombre"  DataField="Name" />
            <asp:BoundField DataField="ID" ShowHeader="False" Visible="False" />
        </Columns>
        
    </asp:GridView>
</div>
</asp:Content>
