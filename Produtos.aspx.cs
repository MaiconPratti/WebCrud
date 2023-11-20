using System;
using System.Collections.Generic;
using WebCrud.Model;

namespace WebCrud
{
    public partial class Produtos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Dados de exemplo
                List<Produto> produtos = new List<Produto>
                {
                    new Produto
                    {
                        Id = 1,
                        Nome = "Fone HeadSet",
                        Descricao = "fone de alta qualidade drivers de 40mm, conector P1, P2.",
                        Preco = 149.90m,
                        Imagem = "Content/Fone.jpg",
                        Status = "Disponível",
                        Vendedor = new Vendedor
                        {
                            NomeFantasia = "Braga's Shop",
                            IdVendedor = "658-745-001",
                        },
                        Categoria = "Eletrônicos"
                    },
                    new Produto
                    {
                        Id = 2,
                        Nome = "Relógio (smartwatch)",
                        Descricao = "Sistema android, notificações de ligações, mensagens, registro de batimentos cardiacos.",
                        Preco = 738.00m,
                        Imagem = "Content/Relogio.jpg",
                        Status = "Disponível",
                        Vendedor = new Vendedor
                        {
                            NomeFantasia = "Shop Mill",
                            IdVendedor = "658-745-002",
                        },
                        Categoria = "Eletrônicos"
                    },

                    new Produto
                    {
                        Id = 3,
                        Nome = "Blusa Nike",
                        Descricao = "Blusa de frio 100% algodão, bolsos com ziper.",
                        Preco = 130.00m,
                        Imagem = "Content/Blusa.jpg",
                        Status = "Disponível",
                        Vendedor = new Vendedor
                        {
                            NomeFantasia = "Lojão do Brás",
                            IdVendedor = "658-745-003",
                        },
                        Categoria = "Vestuário"
                    },

                    // Adicione mais produtos conforme necessário
                };

                // Armazena a lista de produtos em uma variável de sessão
                Session["Produtos"] = produtos;

                rptProdutos.DataSource = produtos;
                rptProdutos.DataBind();
            }

        }

    }
}
