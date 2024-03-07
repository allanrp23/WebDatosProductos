using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebDatosProductos.Clases
{
    public class Conexion_Mysql
    {
        // ATRIBUTOS 
        string var_cadenaconexion_Mysql = "server=localhost; database=gestion_ventas; Uid=root; pwd=;";
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand var_comando = new MySqlCommand();

        // FUNCIONES O MÈTODOS
        public DataSet LeeDatosMysql()
        {
            conn.ConnectionString = var_cadenaconexion_Mysql;
            MySqlDataAdapter da = new MySqlDataAdapter("select * from vista_datos_productos", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }
        //FUNCION PARA INGRESAR DATOS

        public void Insertar(string cod_pro , string nom_pro, int cantidad,decimal precio,
                            string fecha_ela,string fecha_cad,int cat)
        {
            conn.ConnectionString = var_cadenaconexion_Mysql;
            conn.Open();
            string insert = "insert into productos (cod_producto,nom_producto,precio,cantidad,fecha_elab,fecha_cad,cod_categoria) values ('" + cod_pro + "','" + nom_pro + "','" + precio + "', '" + cantidad + "', '" + fecha_ela + "', '" + fecha_cad + "', '" + cat +"' )";
            MySqlCommand cmd = new MySqlCommand(insert, conn);
            int m = cmd.ExecuteNonQuery();
           /* if (m != 0)
            {

            }*/
            conn.Close();

        }



    }
}