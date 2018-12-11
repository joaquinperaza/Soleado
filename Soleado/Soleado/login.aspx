<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Soleado.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>
        Ingreso de usuarios</h2>
    <p>
        Nombre de usuario:<br />
        <asp:TextBox ID="usuario" runat="server"></asp:TextBox>
        <br />
        <br />
        Clave:<br />
        <asp:TextBox ID="clave" runat="server" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Login" />
        <br />
    </p>

</asp:Content>
