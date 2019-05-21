<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="imagens.aspx.cs" Inherits="WebApp_Conflow.imagens" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div style="text-align: center; margin-bottom: 24px;">
        <h1>Imagens</h1>
        
    </div>

    <div style="margin: 0px 2% 0px 2%;">
        
        <!-- Painel de Imagens -->
        <div class="img-panel" style="margin-left: auto; margin-right: auto; display: table;">
            <!-- Imagens -->
            <a href="./img/background2.jpg">
                <div class="img-display">
                    <img src="./img/background2.jpg" style="width: 100%; height: auto;" />
                    <p>Imagem 1</p>
                </div>
            </a>

            <a href="./img/background2.jpg">
                <div class="img-display">
                    <img src="./img/background2.jpg" style="width: 100%; height: auto;" />
                    <p>Imagem 2</p>
                </div>
            </a>

            <a href="./img/background2.jpg">
                <div class="img-display">
                    <img src="./img/background2.jpg" style="width: 100%; height: auto;" />
                    <p>Imagem 3</p>
                </div>
            </a>
        </div>

        <div style="margin: 24px 0px 0px 0px;">
            <p>
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras gravida nisi sed venenatis aliquam.
                Vivamus vitae porttitor ante. Sed non massa vel urna accumsan hendrerit. Quisque tristique nulla a nibh ultrices malesuada.
                Aenean tincidunt tincidunt tellus, vitae imperdiet risus fringilla quis. Duis malesuada semper scelerisque.<br />
                Donec faucibus elit a mollis semper.
            </p>
            <br /><br />
            <p>
                Pellentesque sodales vitae massa in tincidunt.<br />
                Quisque convallis faucibus dui sit amet fringilla. Cras augue nisi, aliquam quis massa faucibus, cursus eleifend eros.
                Proin dignissim, velit sit amet dictum sollicitudin, neque elit gravida arcu, mollis placerat ipsum eros facilisis lacus.
                Nulla bibendum ornare faucibus.
                Maecenas risus erat, gravida at feugiat vitae, rutrum a lectus. Duis ac quam sed dui porttitor tempus vel laoreet dolor.
                In sit amet mauris tristique, venenatis augue vel, eleifend orci.
                Mauris pretium sit amet est ut feugiat. Vestibulum mattis ut neque pretium molestie. Cras egestas elit sit amet vestibulum ultricies.
                Phasellus a est nibh. Donec a ultrices dui, malesuada maximus magna.
                Quisque vestibulum velit ac ante dictum, eu laoreet dui facilisis.
            </p>
            <br /><br />
            <p>
                Proin tincidunt quis sapien eget mattis. Praesent congue sapien ut ex semper vehicula. Aliquam a urna euismod, lacinia lacus id, viverra justo.
                Etiam in tortor sapien. Sed sed porttitor dolor. Suspendisse eu leo eu diam vulputate faucibus. Phasellus vel velit odio. Nulla facilisi.
                Nam dignissim, tellus non elementum egestas, eros elit rhoncus sapien, id fermentum est ex non sem. Donec accumsan ligula ut eros bibendum consequat.
            </p>
        </div>

    </div>


</asp:Content>
