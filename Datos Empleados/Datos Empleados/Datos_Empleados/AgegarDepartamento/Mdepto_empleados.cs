using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos_Empleados
{
    class Mdepto_empleados
    {
        string cadena;
        public virtual string conexiofinal(string conexion)
        {
                cadena = ConfigurationManager.ConnectionStrings[conexion].ConnectionString;
          
            return cadena;
        }

        public virtual string buscarRegistro(string registro, string rc)
        {
            try
            {
                string datobuscar;
                datobuscar = "";
                string sql = "select DEPTO_NO_ID from DEPTOS_NO where NOMBRE  = " + "'" + registro + "'";
                OdbcConnection conn = new OdbcConnection(rc);
                OdbcCommand command = new OdbcCommand(sql, conn);

                conn.Open();
                OdbcDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    datobuscar = reader["DEPTO_NO_ID"].ToString();
                }
                return datobuscar;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
          
        }

        public void cargar_depto(string clave, string ID, string rc)
        {
            try
            {
               
                OdbcConnection conexion = new OdbcConnection();
                conexion.ConnectionString = rc;
                conexion.Open();
                string sql = "insert into CLAVES_CAT_SEC (NOMBRE_TABLA,ELEM_ID,CLAVE)  values ( " + "'" + "DEPTOS_NO" + "'" + ",'" + ID + "'" + ",'" + clave + "'" + ")";

                OdbcCommand comando = new OdbcCommand(sql, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                throw;
            }
        }


        public void agregar_depto(string nombre, string rc)
        {
            try
            {

                OdbcConnection conexion = new OdbcConnection();
                conexion.ConnectionString = rc;
                conexion.Open();
                string sql = "insert into DEPTOS_NO (DEPTO_NO_ID,NOMBRE)  values (GEN_ID(ID_CATALOGOS,1),'" + nombre + "')";

                OdbcCommand comando = new OdbcCommand(sql, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                throw;
            }
        }
    }
}
