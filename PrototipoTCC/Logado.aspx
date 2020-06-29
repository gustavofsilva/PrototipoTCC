<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Logado.aspx.cs" Inherits="PrototipoTCC.Logado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br /><br /><asp:Label ID="Label1" runat="server" Text="Logado com sucesso!"></asp:Label><br />
    <asp:Button ID="Button1" runat="server" Text="Logout" OnClick="Button1_Click" /><br />
</asp:Content>
