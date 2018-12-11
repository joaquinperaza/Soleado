<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="detail.aspx.cs" Inherits="Soleado.detail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        <asp:Label ID="titulo" runat="server"></asp:Label>
    </h2>
    <br />
    Clima:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="climat" runat="server" Width="264px"></asp:TextBox>
&nbsp;<br />
    <br />
    Temperatura:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    <asp:TextBox ID="temp" runat="server"></asp:TextBox>
&nbsp;ºC<br />
    <br />
    Humedad:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="hum" runat="server"></asp:TextBox>
&nbsp; %<br />
    <br />
    Presion:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="presion" runat="server"></asp:TextBox>
&nbsp; hPa<br />
    <br />
    Viento:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="vientovel" runat="server"></asp:TextBox>
&nbsp; nudos
    <asp:TextBox ID="vientodir" runat="server" Width="39px"></asp:TextBox>
    <br />
    <br />
    Nubosidad:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="nubosidad" runat="server"></asp:TextBox>
&nbsp; %<br />
    <br />
    Precipitaciones:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="precipitaciones" runat="server"></asp:TextBox>
&nbsp; mm<br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
