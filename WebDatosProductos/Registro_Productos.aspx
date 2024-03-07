<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro_Productos.aspx.cs" Inherits="WebDatosProductos.Registro_Productos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>REGISTRO PRODUCTOS</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
   <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <asp:TextBox ID="cod_prod" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:TextBox ID="nom_produ" runat="server"></asp:TextBox>
                 <asp:TextBox ID="precio" runat="server"></asp:TextBox>
                 <asp:TextBox ID="cantidad" runat="server"></asp:TextBox>
                 <asp:TextBox ID="fecha_ela" runat="server"></asp:TextBox>
                 <asp:TextBox ID="fecha_cad" runat="server"></asp:TextBox>
                 <asp:TextBox ID="cod_categoria" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="BtnRegistrar" runat="server" CssClass="btn btn-primary" Text="Registrar" OnClick="BtnRegistrar_Click" />
            </div>
        </div>
    </form>
</body>
</html>
