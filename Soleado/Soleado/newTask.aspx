<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="newTask.aspx.cs" Inherits="Soleado.newTask" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <h2>
        Crear alerta</h2>
    <p>
        Nombre:<br />
        <asp:TextBox ID="localidad" runat="server"></asp:TextBox>
        <br />
        <br />
        Coordenadas:<br />
        <asp:TextBox ID="TextBox1" runat="server" Width="94px" ReadOnly="True"></asp:TextBox>
        ,<asp:TextBox ID="TextBox2" runat="server" Width="94px" ReadOnly="True"></asp:TextBox>
        <br />
        <br />
        Tipo de Alerta:<br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="1">SMS</asp:ListItem>
            <asp:ListItem Value="2">Email</asp:ListItem>
            <asp:ListItem Value="3">SMS + EMAIL</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        Periodo de actualizacion:<br />
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem Value="3600">1 hora</asp:ListItem>
            <asp:ListItem Value="86400">1 dia</asp:ListItem>
            <asp:ListItem Value="604800">1 semana</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Crear" />
        <br />
    </p>


</asp:Content>
