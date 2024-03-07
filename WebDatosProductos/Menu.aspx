<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="WebDatosProductos.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>MENU PRINCIPAL</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Btnconsultar" runat="server" Text="Consultar" OnClick="Btnconsultar_Click" />
            <asp:Button ID="Btnregistrar" runat="server" Text="Registrar" OnClick="Btnregistrar_Click" />
        </div>
    </form>
</body>
</html>
