using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebDatosProductos
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnconsultar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Consulta_Productos.aspx");
        }

        protected void Btnregistrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro_Productos.aspx");
        }
    }
}