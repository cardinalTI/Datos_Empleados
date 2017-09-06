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
    class Msueldo_empleado
    {

        string cadena;
        public virtual string conexiofinal(string conexion)
        {
            cadena = ConfigurationManager.ConnectionStrings[conexion].ConnectionString;

            return cadena;
        }


        public virtual string buscarempleado(string empleado, string rc)
        {
            try
            {
                string datobuscar;
                datobuscar = "";
                string sql = "select empleado_id from claves_empleados where clave_empleado  = " + empleado;
                OdbcConnection conn = new OdbcConnection(rc);
                OdbcCommand command = new OdbcCommand(sql, conn);

                conn.Open();
                OdbcDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    datobuscar = reader["empleado_id"].ToString();
                }
                return datobuscar ;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }


        }

        public virtual string buscarRegistro(string registro, string rc)
        {
            try
            {
                string datobuscar;
                datobuscar ="";
                string sql = "select reg_patronal_id from reg_patronales where num_reg_patronal  = " + "'" + registro + "'";
                OdbcConnection conn = new OdbcConnection(rc);
                OdbcCommand command = new OdbcCommand(sql, conn);

                conn.Open();
                OdbcDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    datobuscar = reader["reg_patronal_id"].ToString();
                }
                return datobuscar ;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
         
        }

        public void cargarsueldos(string id_empleado, string registro_patronal, string tipo, string fecha, string salario_diario,string salario_hora,string salario_integrado, string rc)
        {

            try
            {
                DateTime enteredDate = DateTime.Parse(fecha);
                fecha = enteredDate.ToString("dd.MM.yyyy");

                OdbcConnection conexion = new OdbcConnection();
                conexion.ConnectionString = rc;
                conexion.Open();
                string sql = "insert into incidencias (INCIDENCIA_ID,EMPLEADO_ID,REG_PATRONAL_ID,TIPO,FECHA,SALARIO_DIARIO,SALARIO_HORA,SALARIO_INTEG,SALINT_DEFAULT,FORMA_EMITIDA) values (GEN_ID(ID_DOCTOS,1),'" + id_empleado + "','" + registro_patronal + "','" + tipo + "','" + fecha + "','" + salario_diario + "','" + salario_hora + "','" + salario_integrado + "','" + "S" + "', '" + "N" + "')";

                OdbcCommand comando = new OdbcCommand(sql,conexion );
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
