<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carrinho.aspx.cs" Inherits="WebCrud.Carrinho" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="CSS/StyleSheetCarrinho.css" />
    <title>Carrinho de Compras</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="conteudo" id="divCarrinho" runat="server" style="text-align: center;
            margin: auto;">
            <h2>Seu Carrinho de Compras</h2>
            <div class="carrinho-table">
                <asp:Repeater ID="rptCarrinho" runat="server">
                    <ItemTemplate>
                        <div class="produto-item">
                            <div class="produto-imagem">
                                <img src='<%# Eval("Imagem") %>' alt='<%# Eval("Nome") %>' width="100" />
                            </div>
                            <div>
                                <h3><%# Eval("Nome") %></h3>
                                <p>Preço: <%# String.Format("{0:C}", Eval("Preco")) %></p>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <div class="total-carrinho">
                Valor Total: <%# String.Format("{0:C}", Eval("TotalCarrinho")) %>
            </div>
           <asp:Button ID="confirmarCompraBtn" runat="server" Text="Confirmar Compra" OnClick="ConfirmarCompra_Click" CssClass="botao" />
        </div>
    </form>
</body>
</html>
