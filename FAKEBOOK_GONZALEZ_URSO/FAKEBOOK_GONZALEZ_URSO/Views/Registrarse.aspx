<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="FAKEBOOK_GONZALEZ_URSO.Registrarse" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ingrese sus datos para crear su usuario</title>
    <link href="../Styles/REGISTRARSE.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <br />
    <br />
    <table border="1">
        <tr>
            <td><p> NOMBRE </p></td>
            <td>
                <asp:TextBox ID="FirstName" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="FirstName" ForeColor="Red" runat="server" Text="*" />
            </td>
        </tr>
        <tr>
            <td><p> APELLIDO </p></td>
            <td>
                <asp:TextBox ID="LastName" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="LastName" ForeColor="Red" runat="server" Text="*" />
            </td>
        </tr>
        <tr>
            <td><p> E-MAIL </p></td>
            <td>
                <asp:TextBox ID="Email" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="Email" ForeColor="Red" runat="server" Text="*" />
            </td>
        </tr>
        <tr>
            <td><p> REPITA SU E-MAIL </p></td>
            <td>
                <asp:TextBox ID="ConfirmMail" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="ConfirmMail" ForeColor="Red" runat="server" Text="*" />
                <%--agregar compareValidator entre email y confirm--%>
            </td>
        </tr>
        <tr>
            <td><p> CONTRASEÑA </p></td>
            <td>
                <asp:TextBox ID="Password" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="Password" ForeColor="Red" runat="server" Text="*" />
            </td>
        </tr>
        <tr>
            <td><p> REPITA SU CONTRASEÑA </p></td>
            <td>
                <asp:TextBox ID="ConfirmPassword" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="ConfirmPassword" ForeColor="Red" runat="server" Text="*" />
                <%--agregar compareValidator entre Password y confirm--%>
            </td>
        </tr>
    </table>
    <br />
    &nbsp;<asp:Label ID="MsjLabel" runat="server" Text="" />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="&nbsp;&nbsp;Complete los campos con *" ForeColor="Red" ShowSummary="True" ShowMessageBox="False" DisplayMode="SingleParagraph" />
    <br />
    <br />
    <br />
    <asp:ImageButton ID="ImageButton1" runat="server" 
        ImageUrl="~/Styles/Images/REGISTRAR.jpg" Width="327px" 
        onclick="ImageButton1_Click" />
    <br />
    <br />
    &nbsp;<a href="Login.aspx" title="Volver al Inicio">Volver al Inicio</a>
    <%--<asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>--%>
    </form>
</body>
</html>
