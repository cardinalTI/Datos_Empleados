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
    class Mpuesto_empleados
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
                string sql = "select Puesto_NO_ID from PUESTOS_NO where NOMBRE  = " + "'" + registro + "'";
                OdbcConnection conn = new OdbcConnection(rc);
                OdbcCommand command = new OdbcCommand(sql, conn);

                conn.Open();
                OdbcDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    datobuscar = reader["PUESTO_NO_ID"].ToString();
                }
                return datobuscar;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }

        }

        public void agregar_puesto(string nombre, string minimo, string maximo, string rc)
        {
            try
            {

                OdbcConnection conexion = new OdbcConnection();
                conexion.ConnectionString = rc;
                conexion.Open();
                string sql = "insert into PUESTOS_NO (PUESTO_NO_ID,NOMBRE,SUELDO_DIARIO, SUELDO_DIARIO_MAX)  values (GEN_ID(ID_CATALOGOS,1),'" + nombre + "'" + "," + minimo +","+ maximo+ ")";

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


        public void cargar_puesto(string clave, string ID, string rc)
        {
            try
            {

                OdbcConnection conexion = new OdbcConnection();
                conexion.ConnectionString = rc;
                conexion.Open();
                string sql = "insert into CLAVES_CAT_SEC (NOMBRE_TABLA,ELEM_ID,CLAVE)  values ( " + "'" + "PUESTOS_NO" + "'" + ",'" + ID + "'" + ",'" + clave + "'" + ")";

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
