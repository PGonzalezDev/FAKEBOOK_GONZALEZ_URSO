<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="FAKEBOOK_GONZALEZ_URSO.Registrarse" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ingrese sus datos para crear su usuario</title>
    <link href="REGISTRARSE.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <br />
    <br />
    <table border=1>
    <tr>
    <td><p> NOMBRE </p></td>
    <td>
        <asp:TextBox ID="FirstName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
    <td><p> APELLIDO </p></td>
    <td>
        <asp:TextBox ID="LastName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
    <td><p> E-MAIL </p></td>
    <td>
        <asp:TextBox ID="Email" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
    <td><p> REPITA SU E-MAIL </p></td>
    <td>
        <asp:TextBox ID="ConfirmMail" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
    <td><p> CONTRASEÑA </p></td>
    <td>
        <asp:TextBox ID="Password" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
    <td><p> REPITA SU CONTRASEÑA </p></td>
    <td>
        <asp:TextBox ID="ConfirmPassword" runat="server"></asp:TextBox>
        </td>
    </tr>
    </table>
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:ImageButton ID="ImageButton1" runat="server" 
        ImageUrl="~/Styles/Images/REGISTRAR.jpg" Width="327px" 
        onclick="ImageButton1_Click" />
    </form>
</body>
</html>
