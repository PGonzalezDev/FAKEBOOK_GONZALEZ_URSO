<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FAKEBOOK_GONZALEZ_URSO.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bienvenido a FAKEBOOK ingrese sus datos correctamente para continuar, Gracias por elegir FAKEBOOK!!!!</title>
   
    <link href="~\Styles\LOGIN.css" rel="stylesheet" type="text/css" />
    </head>
<body>
    <form id="form1" runat="server">
    <table class="loginTable" border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td class="loginLabel">
                <asp:Image ID="Image1" runat="server" Height="39px" 
                    ImageUrl="~/Styles/Images/E-MAIL.jpg" Width="229px" />
            </td>
            <td>
                <asp:TextBox ID="LoginTxt" runat="server" Height="35px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="loginLabel">
                <asp:Image ID="Image2" runat="server" Height="36px" 
                    ImageUrl="~/Styles/Images/CONTRASEÑA.jpg" Width="209px" />
            </td>
            <td>
                <asp:TextBox ID="PassTxt" TextMode="Password" runat="server" Height="35px" ControlToValidate="PassTxt"></asp:TextBox>
                <asp:RequiredFieldValidator ID="PasswordRequiredValidator" runat="server" 
                    ErrorMessage="Este campo es Requerido" ValidationGroup="LoguinValidationGroup" 
                    ControlToValidate="PassTxt" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:ImageButton ID="ImageButton1" runat="server" 
                    ImageUrl="~/Styles/Images/INGRESAR.jpg" onclick="ImageButton1_Click" />
            </td>
        </tr>
        <tr></tr>
    </table>
    <table border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td>
                <asp:ImageButton ID="ImageButton2" runat="server" 
                ImageUrl="~/Styles/Images/REGISTRAR.jpg" onclick="ImageButton2_Click" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>

