using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCrud
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            if (AutenticarUsuario(email, senha))
            {
                // Autenticação bem-sucedida
                // Redirecionar para a página principal ou fazer outras ações necessárias
                Response.Redirect("Produtos.aspx");
            }
            else
            {
                // Autenticação falhou
                Response.Write("Autenticação falhou. Verifique seu e-mail e senha.");
            }
        }

        private bool AutenticarUsuario(string email, string senha)
        {
            // Lógica de autenticação simples (substitua por uma lógica real se necessário)
            return (email.ToLower() == "usuario@exemplo.com" && senha == "senha123");
        }
    }
}