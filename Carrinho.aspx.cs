using System;
using System.Collections.Generic;
using System.Linq;
using WebCrud.Model;

namespace WebCrud
{
    public partial class Carrinho : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AtualizarCarrinho();
            }
        }

        private Produto ObterProdutoPorId(int produtoId)
        {
            // Você precisa implementar a lógica para obter o produto do seu armazenamento de produtos
            // Aqui, estamos assumindo que a lista de produtos está na sessão com a chave "Produtos"
            List<Produto> produtos = Session["Produtos"] as List<Produto>;

            // Retorna o produto com o ID correspondente
            return produtos?.FirstOrDefault(p => p.Id == produtoId);
        }

        private void AtualizarCarrinho()
        {
            List<Produto> carrinhoItens = ObterCarrinho();

            // Garante que a quantidade mínima é 1 para todos os produtos no carrinho
            carrinhoItens.ForEach(p => p.Quantidade = Math.Max(p.Quantidade, 1));

            // Atualiza a propriedade TotalProduto para cada produto no carrinho
            carrinhoItens.ForEach(p => p.TotalProduto = p.Preco * p.Quantidade);

            // Adiciona um item especial para representar o total no carrinho
            carrinhoItens.Add(new Produto
            {
                Nome = "Total",
                TotalProduto = carrinhoItens.Sum(p => p.TotalProduto)
            });

            // Exibe os produtos na tabela HTML
            ExibirProdutosNoCarrinho(carrinhoItens);
        }

        private void ExibirProdutosNoCarrinho(List<Produto> carrinhoItens)
        {
            // Cria uma tabela HTML para exibir os produtos no carrinho
            string tabelaHtml = "<table border='1'><tr><th>Produto</th><th>Imagem</th><th>Preço</th><th>Quantidade</th><th>Total</th><th>Ações</th></tr>";

            for (int i = 0; i < carrinhoItens.Count - 1; i++) // Exclui a última linha que representa o total
            {
                Produto produto = carrinhoItens[i];
                tabelaHtml += $"<tr><td>{produto.Nome}</td><td><img src='{produto.Imagem}' alt='{produto.Nome}' height='50' width='50'></td><td>{produto.Preco:C}</td><td>{produto.Quantidade}</td><td>{produto.TotalProduto:C}</td><td><a href='ExcluirProduto.aspx?id={produto.Id}'>Excluir</a> | <a href='AlterarQuantidade.aspx?id={produto.Id}'>Alterar Quantidade</a></td></tr>";
            }

            tabelaHtml += "</table>";

            // Exibe a tabela na página
            divCarrinho.InnerHtml = tabelaHtml;

            // Adiciona o botão "Confirmar Compra"
            divCarrinho.InnerHtml += "<br /><br /><button onclick='ConfirmarCompra()' class='botao'>Confirmar Compra</button>";

            // Exibe o valor total abaixo da tabela
            divCarrinho.InnerHtml += $"<br /><br /><strong>Valor Total: {carrinhoItens.Last().TotalProduto:C}</strong>";
        }

        private List<Produto> ObterCarrinho()
        {
            List<Produto> produtos = Session["Produtos"] as List<Produto>;
            return produtos ?? new List<Produto>();
        }

        protected void ConfirmarCompra_Click(object sender, EventArgs e)
        {
            // Adicione o código que deve ser executado ao clicar no botão Confirmar Compra
            // Por exemplo, redirecionar para uma página de confirmação de compra
            Response.Redirect("PaginaDeConfirmacao.aspx");
        }
    }
}
