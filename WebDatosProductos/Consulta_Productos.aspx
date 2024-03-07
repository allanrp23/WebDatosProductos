<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta_Productos.aspx.cs" Inherits="WebDatosProductos.Consulta_Productos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>CONSULTA DE PRODUCTOS</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="Grid_Datos" runat="server"></asp:GridView>
            <asp:Button ID="BtnConsultar" runat="server" Text="Consultar" OnClick="BtnConsultar_Click" />
        </div>

        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </form>
</body>
</html>
