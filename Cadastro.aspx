<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="WebCrud.Cadastro" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="CSS/StyleSheetCadastro.css" />
    <title>CADASTRO</title>

</head>
<body>
    <form runat="server" id="formCadastro" method="post" onservervalidate="formCadastro_ServerValidate">
        <div class="container">
            <div class="dark-box">
                <div class="row">
                    <div class="col-md-12">
                        <h1>CADASTRO</h1>

                        <label for="nome">Nome:</label>
                        <asp:TextBox runat="server" ID="nome" Required="true"></asp:TextBox>

                        <label for="cpfCnpj">CPF/CNPJ:</label>
                        <asp:TextBox runat="server" ID="cpfCnpj" Required="true"></asp:TextBox>

                        <label for="email">E-mail:</label>
                        <asp:TextBox runat="server" ID="email" Required="true"></asp:TextBox>

                        <label for="senha">Senha:</label>
                        <asp:TextBox runat="server" ID="senha" TextMode="Password" Required="true"></asp:TextBox>

                        <div runat="server" id="vendedorFields" style="display: none;">
                            <label for="razaoSocial">Razão Social:</label>
                            <asp:TextBox runat="server" ID="razaoSocial"></asp:TextBox>

                            <label for="nomeFantasia">Nome Fantasia:</label>
                            <asp:TextBox runat="server" ID="nomeFantasia"></asp:TextBox>

                        </div>

                        <label>Selecione o seu papel:</label>
                        <br />
                        <br />
                        <div class="checkbox-group">
                            <asp:RadioButton runat="server" ID="radioVendedor" GroupName="papel" Text="Vendedor"
                                OnCheckedChanged="radioPapel_CheckedChanged" AutoPostBack="true" />
                            <asp:RadioButton runat="server" ID="radioComprador" GroupName="papel" Text="Comprador"
                                OnCheckedChanged="radioPapel_CheckedChanged" AutoPostBack="true" />
                        </div>
                        <br />

                        <asp:Button CssClass="botao" runat="server" ID="btnCadastrar" Text="Cadastrar" OnClick="btnCadastrar_Click" />


                    </div>
                </div>
    </form>

    <script>
        // Função para exibir/ocultar campos específicos do vendedor
        document.getElementById('<%= radioVendedor.ClientID %>').addEventListener('change', function () {
            var vendedorFields = document.getElementById('<%= vendedorFields.ClientID %>');
            vendedorFields.style.display = this.checked ? 'block' : 'none';
        });
    </script>
</body>
</html>
