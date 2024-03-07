using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebDatosProductos.Clases;

namespace WebDatosProductos
{
    public partial class Registro_Productos : System.Web.UI.Page
    {
        Conexion_Mysql obcone=new Conexion_Mysql();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {
            string cod, nom,fecha_el,fecha_cad;
            decimal prec;
            int cantidad,codcategoria;

            cod = this.cod_prod.Text;
            nom = this.nom_produ.Text;
            fecha_el = this.fecha_ela.Text;
            fecha_cad = this.fecha_cad.Text;
            cantidad = Convert.ToInt32(this.cantidad.Text);
            prec =Convert.ToDecimal(  this.precio.Text);
            codcategoria =Convert.ToInt32( this.cod_categoria.Text);
            obcone.Insertar(cod, nom, cantidad, prec, fecha_el, fecha_cad, codcategoria);
        }

        
    }
}