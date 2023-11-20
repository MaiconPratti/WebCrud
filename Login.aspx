<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebCrud.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="CSS/StyleSheetLogin.css" /> <!-- Link para o arquivo CSS externo -->
    <title>Login</title>
</head>
<body>
    <div style="display: flex; align-items: center; justify-content: center; min-height: 100vh;">
        <div style="background-color: #000; padding: 20px; border-radius: 8px; box-shadow: 0 0 10px rgba(0, 0, 0, 0.1); color: #ffffff; text-align: center;">
            <h1 style="margin-bottom: 20px;">* MARKETPLACE *</h1>
            <p>Por favor entre com seu Email e Senha.</p>
            <form id="form1" runat="server">
                <div style="margin-bottom: 15px;">
                    <label for="txtEmail" style="display: block; margin-bottom: 5px;">Endereço de email</label>
                    <asp:TextBox ID="txtEmail" runat="server" style="width: 100%; padding: 8px; box-sizing: border-box; border: 1px solid #ced4da; border-radius: 4px;" ClientIDMode="Static" />
                    <div style="margin-top: 5px; color: #6c757d;">
                        Fique tranquilo, nunca compartilharemos seu e-mail.
                    </div>
                </div>
                <div style="margin-bottom: 15px;">
                    <label for="txtSenha" style="display: block; margin-bottom: 5px;">Digite sua senha</label>
                    <asp:TextBox ID="txtSenha" runat="server" style="width: 100%; padding: 8px; box-sizing: border-box; border: 1px solid #ced4da; border-radius: 4px;" TextMode="Password" ClientIDMode="Static" />
                </div>
                <div style="margin-top: 10px;">
                    <asp:CheckBox ID="chkManterConectado" runat="server" />
                    <label for="chkManterConectado" style="margin-left: 5px;">Manter-me conectado</label>
                </div>
                <asp:Button ID="btnEntrar" runat="server" Text="Entrar" style="background-color: #007bff; color: #ffffff; padding: 10px 20px; border: none; border-radius: 4px; cursor: pointer; margin-top: 10px;" OnClick="btnEntrar_Click" />
            </form>
        </div>
    </div>
</body>
</html>
