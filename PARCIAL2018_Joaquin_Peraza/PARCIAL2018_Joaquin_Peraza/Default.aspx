<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="PARCIAL2018_Joaquin_Peraza._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Consulta facturas
    </h2>
    <p>
        CONSULTA POR CLIENTE:<br />
        CLIENTE:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Total:" />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        DESDE:
        <asp:TextBox ID="TextBox3" runat="server" TextMode="DateTime"></asp:TextBox>
&nbsp;HASTA
        <asp:TextBox ID="TextBox4" runat="server" TextMode="DateTime"></asp:TextBox>
&nbsp;<asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Total:" />
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    </p>
    <p>
        LOCALIDAD
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
            Text="MOSTRAR" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
    </p>
</asp:Content>
