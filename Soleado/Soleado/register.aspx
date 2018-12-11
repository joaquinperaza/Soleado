<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="Soleado.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Registro de usuarios</h2>
    <p>Nombre de usuario:<br />
        <asp:TextBox ID="usuario" runat="server"></asp:TextBox>
        <br />
        <br />
        Email:<br />
        <asp:TextBox ID="email" runat="server"></asp:TextBox>
        <br />
        <br />
        Telefono:<br />
        <asp:TextBox ID="telefono" runat="server"></asp:TextBox>
        <br />
        <br />
        Clave:<br />
        <asp:TextBox ID="clave" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        Tipo de membresia:<br />
        <asp:DropDownList ID="DropDownList3" runat="server">
            <asp:ListItem>GRATIS</asp:ListItem>
            <asp:ListItem>PREMIUM</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="CREAR" />
    </p>
    <p>&nbsp;</p>
     <br />
</asp:Content>
