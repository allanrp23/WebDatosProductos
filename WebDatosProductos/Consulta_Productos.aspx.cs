using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebDatosProductos.Clases;

namespace WebDatosProductos
{
    public partial class Consulta_Productos : System.Web.UI.Page
    {
        Conexion_Mysql obj=new Conexion_Mysql();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnConsultar_Click(object sender, EventArgs e)
        {
            Consulta_Datos();
        }
        private void Consulta_Datos()
        {

            DataSet ds = obj.LeeDatosMysql();
            Grid_Datos.DataSource = ds.Tables[0];
            Grid_Datos.DataBind();
        }

    }// FIN DE LA CLASE
}