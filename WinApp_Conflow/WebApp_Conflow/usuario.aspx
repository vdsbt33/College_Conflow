<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="usuario.aspx.cs" Inherits="WebApp_Conflow.usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="text-align: center; margin-bottom: 24px;">
        <h1>Acesso do usuário</h1>
    </div>
    
    <div style="margin: 0px 2% 0px 2%;">
        
        <div style="margin-left: auto; margin-right: auto; display: table;">
            <div style="float: left; text-align: right;">
                <b>
                    <span style="margin: 1px 0px 0px 0px; display: block;"></span>
                    <asp:Label ID="nomeLabel" runat="server">Nome de Usuário: </asp:Label>
                    <br /><br />
                    <span style="margin: 5px 0px 0px 0px; display: block;"></span>
                    <asp:Label ID="senhaLabel" runat="server" >Senha: </asp:Label>
                    <br /><br />
                </b>
            </div>
            <div style="float: left;">
                <asp:TextBox ID="nomeTbox" runat="server" class="tbox"></asp:TextBox>
                <br /><br />
                <asp:TextBox ID="senhaTbox" runat="server" TextMode="Password" class="tbox"></asp:TextBox>
            </div>
            <br />
            <asp:Button ID="conectarBtn" runat="server" Text="Conectar" class="btn" style="margin: 12px 0px 0px 0px;" OnClick="conectarBtn_onClick" />
            <br /><br />
            <asp:Label ID="avisoLabel" runat="server" style="display: inline-block; text-align: center;"></asp:Label>
        </div>

    </div>


</asp:Content>
