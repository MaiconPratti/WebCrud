<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Produtos.aspx.cs" Inherits="WebCrud.Produtos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="https://code.jquery.com/jquery-3.6.4.min.js"></script>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="CSS/StyleSheetProdutos.css" />
    <title>Produtos</title>

</head>
<body>
    <form id="form1" runat="server">

        <div>
            <!-- Adicione um botão para ir para a página Carrinho -->
            <asp:Button CssClass="botao" Style="position:fixed" runat="server" Text="Ir para o Carrinho" OnClientClick="window.location.href='Carrinho.aspx'; return false;" />
        </div>

        <div class="produtos-container">
            <div class="produtos-box">
                <h1>Produtos Disponíveis</h1>

                <asp:Repeater ID="rptProdutos" runat="server">
                    <ItemTemplate>
                        <div style="border: 2px solid #ddd; padding: 10px; margin-bottom: 10px;">
                            <h2><%# Eval("Nome") %></h2>
                            <h3><%# Eval("Descricao") %></h3>
                            <p>Preço: R$ <%# Eval("Preco") %></p>
                            <p>Status: <%# Eval("Status") %></p>
                            <p>Vendedor: <%# Eval("Vendedor.NomeFantasia") %></p>
                            <p>Id do Vendedor: <%# Eval("Vendedor.IdVendedor") %></p>
                            <p>Categoria: <%# Eval("Categoria") %></p>
                            <img src='<%# Eval("Imagem") %>' alt="Imagem do Produto" style="max-width: 200px;" />
                            <br />
                            <!-- Adicionar botão "Adicionar ao Carrinho" -->
                            <asp:Button CssClass="botao" runat="server" Text="Adicionar ao Carrinho" OnClientClick='<%# "adicionarAoCarrinho(" + Eval("Id") + "); return false;" %>' />

                            <hr />
                        </div>
                    </ItemTemplate>
                </asp:Repeater>

            </div>
        </div>
    </form>

   <script type="text/javascript">
       function adicionarAoCarrinho(idProduto) {
           $.ajax({
               type: "POST",
               url: "Carrinho.aspx/AdicionarProdutoAoCarrinho",
               data: JSON.stringify({ idProduto: idProduto }),
               contentType: "application/json; charset=utf-8",
               dataType: "json",
               success: function () {
                   alert("Produto adicionado ao carrinho!");
               },
               failure: function () {
                   alert("Erro ao adicionar produto ao carrinho!");
               }
           });
       }
   </script>


</body>
</html>
