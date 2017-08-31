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
    class Mcuentas
    {

        string cadena;
        public virtual string conexiofinal(string conexion)
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

        public void cargarcuentas(string numero, string cuenta, string rc)
        {
            string cuentacompleta;
          cuentacompleta=  cuenta + "000000000000000000000000000000000000000000000000000000000000000000";
            cuenta= (cuentacompleta.Substring (0,11));
            try
            {
                OdbcConnection conexion = new OdbcConnection();
                conexion.ConnectionString = rc;
                conexion.Open();
                string sql = "update empleados set NUM_CTABAN_PAGO_ELECT = '" + cuenta + "' where numero = '" + numero + "' ";
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

        //buscar banco

        public virtual string buscarRegistro(string banco, string rc)
        {
            try
            {
                string datobuscar;
                datobuscar = "";
                string sql = "select GRUPO_PAGO_ELECT_ID from GRUPOS_PAGOS_ELECT where nombre  = " + "'" + banco + "'";
                OdbcConnection conn = new OdbcConnection(rc);
                OdbcCommand command = new OdbcCommand(sql, conn);

                conn.Open();
                OdbcDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    datobuscar = reader["GRUPO_PAGO_ELECT_ID"].ToString();
                }
                return datobuscar;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
           
        }


        public void cargarbancos(string numero,string banco,string rc, string empresa)
        {
           
            try
            {
                OdbcConnection conexion = new OdbcConnection();
                conexion.ConnectionString = rc;
                conexion.Open();
                string sql = "update empleados set GRUPO_PAGO_ELECT_ID = '" + banco + "' where numero = '" + numero + "' ";
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
