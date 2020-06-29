<%@ Page Title="Login" Language="C#"MasterPageFile="~/Site.Master" AutoEventWireup="false" CodeBehind="Login.aspx.cs" Inherits="PrototipoTCC.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    
    <asp:TextBox ID="TextBoxEmail" runat="server" placeholder="Email" ></asp:TextBox>&nbsp<asp:Label ID="LabelEmail" runat="server" Text="Precisa ter @"></asp:Label>
    <br />
    <asp:TextBox ID="TextBoxSenha" runat="server" placeholder="Senha" Height="22px"></asp:TextBox>&nbsp<asp:Label ID="LabelSenha" runat="server" Text="Precisa ter letras e números"></asp:Label>
    <br />
    <asp:Label ID="LabelResult" runat="server"></asp:Label>
    <br />
    <asp:Button ID="ButtonLogin" runat="server" Text="Login" OnClick="Button1_Click" />
        
    
</asp:Content>

