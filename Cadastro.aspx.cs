using System;

namespace WebCrud
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Pode adicionar lógica de inicialização aqui, se necessário
        }

        protected void radioPapel_CheckedChanged(object sender, EventArgs e)
        {
            vendedorFields.Style["display"] = radioVendedor.Checked ? "block" : "none";
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nomeValue = nome.Text;
            string cpfCnpjValue = cpfCnpj.Text;
            string emailValue = email.Text;
            string senhaValue = senha.Text;

            if (radioVendedor.Checked)
            {
                // Processar cadastro de vendedor
                string razaoSocialValue = razaoSocial.Text;
                string nomeFantasiaValue = nomeFantasia.Text;
                

                // Crie uma instância da classe Vendedor e faça o que for necessário
            }
            else if (radioComprador.Checked)
            {
                // Processar cadastro de comprador
                // Adicione a lógica aqui, se necessário
            }
            else
            {
                // Papel inválido, tratar conforme necessário
            }

            // Redirecionar para uma página de sucesso ou tratamento de erro
            Response.Redirect("PaginaSucesso.aspx");
        }
    }
}
