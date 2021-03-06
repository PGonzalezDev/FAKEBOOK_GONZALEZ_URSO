﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="FAKEBOOK_GONZALEZ_URSO.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="PostDiv">
        <asp:Label ID="Label1" runat="server" Text="¿Que esta Pasando?" /> <br />
        <asp:TextBox ID="PublicationTxt" TextMode="MultiLine" runat="server" MaxLength="500" CssClass="Publicationtxt" /> <br />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="PublicationTxt" ValidationExpression="^[\s\S]{0,500}$" runat="server" Display="Dynamic" ForeColor="Red" ErrorMessage="El largo maximo es de 500 Caracteres" /><br />
        <asp:Button ID="Post" runat="server" Text="Publicar" onclick="Post_Click" /> <br />
        <asp:Label ID="ErrorLabel" runat="server" ForeColor="Red" Text="" /> <br />
    </div>

    <%--<div id="Publications" runat="server">
    </div>--%>
    <br />
    <asp:GridView ID="GridView1" runat="server" BackColor="#E1E6F0" BorderColor="Black" BorderWidth="2" AutoGenerateColumns="false" 
        Width="50%" DataKeyNames="Id" OnRowDeleting="GridView1_RowDeleting">
        <Columns>
            <asp:BoundField DataField="UserName" HeaderText="Usuario" />
            <asp:BoundField DataField="Text" HeaderText="Mensaje" />
            <asp:BoundField DataField="Image" HeaderText="Imagen" />
            <asp:BoundField DataField="Date_Time" HeaderText="Fecha y Hora" />
            <asp:HyperLinkField Text="Comentarios" NavigateUrl="~/Views/index.aspx" />
            <asp:ButtonField CommandName="Delete" Text="Eliminar" />
        </Columns>
    </asp:GridView>
</asp:Content>
