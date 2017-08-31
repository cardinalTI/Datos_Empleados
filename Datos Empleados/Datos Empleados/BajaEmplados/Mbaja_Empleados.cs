using Datos_Empleados.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Odbc;
using FirebirdSql.Data.FirebirdClient;
using System.Windows.Forms;

namespace Datos_Empleados

{

    
    class Mbaja_Empleados
    {
        string cadena;
        public virtual string   conexiofinal (string conexion)
        {

            if (conexion == "NUBULA")
            {
                cadena = ConfigurationManager.ConnectionStrings["NUBULA"].ConnectionString;
            }
            if (conexion == "INFORMATION THECNOLOGY INDUSTRIES")
            {
                cadena = ConfigurationManager.ConnectionStrings["INFORMATION THECNOLOGY INDUSTRIES"].ConnectionString;
            }
            if (conexion == "FOLDUR")
            {
                cadena = ConfigurationManager.ConnectionStrings["FOLDUR"].ConnectionString;
            }
            if (conexion == "MORGET")
            {
                cadena = ConfigurationManager.ConnectionStrings["MORGET"].ConnectionString;
            }
            if (conexion == "GRUPO CONISAL")
            {
                cadena = ConfigurationManager.ConnectionStrings["GRUPOCONISAL"].ConnectionString;
            }
            if (conexion == "WIPSI")
            {
                cadena = ConfigurationManager.ConnectionStrings["WIPSI"].ConnectionString;
            }
            if (conexion == "MORGET SEMANAL")
            {
                cadena = ConfigurationManager.ConnectionStrings["MORGETSEMANAL"].ConnectionString;
            }
            if (conexion == "MORGET CATORCENAL")
            {
                cadena = ConfigurationManager.ConnectionStrings["MORGETCATORCENAL"].ConnectionString;
            }
            if (conexion == "MORGET QUINCENAL")
            {
                cadena = ConfigurationManager.ConnectionStrings["MORGETQUINCENAL"].ConnectionString;
            }
            if (conexion == "MORGET MENSUAL")
            {
                cadena = ConfigurationManager.ConnectionStrings["MORGETMENSUAL"].ConnectionString;
            }
            if (conexion == "IT TELECOM")
            {
                cadena = ConfigurationManager.ConnectionStrings["ITTELECOM"].ConnectionString;
            }
            if (conexion == "MORGET INTERNA")
            {
                cadena = ConfigurationManager.ConnectionStrings["MORGETINTERNA"].ConnectionString;
            }
            if (conexion == "AICEL")
            {
                cadena = ConfigurationManager.ConnectionStrings["AICEL"].ConnectionString;
            }
            if (conexion == "CONSORCIO ATERAP SA DE CV")
            {
                cadena = ConfigurationManager.ConnectionStrings["CONSORCIOATERAPSADECV"].ConnectionString;
            }
            if (conexion == "CROTEC SA DE CV")
            {
                cadena = ConfigurationManager.ConnectionStrings["CROTECSADECV"].ConnectionString;
            }
            if (conexion == "PEPSAT SA DE CV")
            {
                cadena = ConfigurationManager.ConnectionStrings["PEPSATSADECV"].ConnectionString;
            }
            if (conexion == "UPHETILOLI 2")
            {
                cadena = ConfigurationManager.ConnectionStrings["UPHETILOLI2"].ConnectionString;
            }

            return cadena;
        }

        public virtual string buscarempleado(string empleado,string rc)
        {
            string datobuscar;
            datobuscar = "";
            try
               
            {
                
                string sql = "select empleado_id from claves_empleados where clave_empleado  = " + empleado  ;
                OdbcConnection conn = new OdbcConnection(rc);
                OdbcCommand command = new OdbcCommand(sql, conn);
                
                conn.Open();
                OdbcDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    datobuscar = reader["empleado_id"].ToString();
                }
                return datobuscar  ;
            }
            catch (Exception e )
            {
                MessageBox.Show(e.ToString());
                throw;
            }

       
        }

        public virtual string  buscarRegistro(string registro,string rc)
        {
            try
            {
                string datobuscar;
                datobuscar = "";
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
                MessageBox.Show(e.ToString ());
                throw;
            }
            return registro;
        }

        public void cargar(string id_empleado,string registro_patronal,string tipo, string fecha,string causa_baja,string rc)
        {


            try
            {

                DateTime enteredDate = DateTime.Parse(fecha);
                fecha = enteredDate.ToString("dd.MM.yyyy");

                OdbcConnection conexion = new OdbcConnection();
                conexion.ConnectionString = rc;
                conexion.Open();
                string sql = "insert into incidencias (INCIDENCIA_ID,EMPLEADO_ID,REG_PATRONAL_ID,TIPO,FECHA,CAUSA_BAJA,SALINT_DEFAULT,FORMA_EMITIDA) values (GEN_ID(ID_DOCTOS,1),'" + id_empleado + "','" + registro_patronal + "','" + tipo + "','" + fecha + "','" + causa_baja + "','" + "S" + "', '" + "N" + "')";
                OdbcCommand comando = new OdbcCommand(sql,conexion);
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
