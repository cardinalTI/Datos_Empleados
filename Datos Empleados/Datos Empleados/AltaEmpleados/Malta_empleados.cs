using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos_Empleados
{
    class Malta_empleados
    {
        //string conexionSQL = "data source= 192.168.2.82; Initial Catalog= microsip; user id=sicossadmi;password=ipp2012;";
        string conexionSQL = "data source= 201.139.106.58; Initial Catalog= microsip; user id=sicossadmi;password=ipp2012;";
        
        private SqlConnection m_ConnODBC2009;
        private ArrayList arreDatos = new ArrayList();
        public void eliminar()
        {
            try
            {
                SqlConnection conexion = new SqlConnection();
                conexion.ConnectionString = conexionSQL;
                conexion.Open();
                SqlCommand comando = new SqlCommand("delete from usuario", conexion);
                if (comando.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Conexion correcta");

                }
                else
                {
                    MessageBox.Show("Error al probar conexiòn");
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show("Error" + ex.Message );
                throw;
            }

        }

        public void cargar(string numero,string nombre,string apellido_paterno,string apellido_materno,string clave_puesto, string clave_depto,string clave_frecuencia_pago,
          string num_reg_patronal,string forma_pago,string contrato,string jornada,string regimen_fiscal,string fecha_ingreso, string estatus, string tipo_salario,string salario_diario,string salario_integrado,
          string rfc,string curp,string registro_imss,string direccion, string cp, string contratosat)
        {
            try
            {
                SqlConnection conexion = new SqlConnection();
                conexion.ConnectionString = conexionSQL;
                conexion.Open();
                SqlCommand comando = new SqlCommand("insert into usuario (numero,nombres,apellido_paterno,apellido_materno,clave_puesto,clave_depto,clave_frecuencia_pago,num_reg_patronal,forma_pago,contrato,jornada,regimen_fiscal,fecha_ingreso,estatus,tipo_salario,salario_diario,salario_integrado,rfc,curp,registro_imss,direccion,cp,contrato_sat) values ('" + numero + "','" + nombre + "','" + apellido_paterno + "','" + apellido_materno + "','" + clave_puesto + "','" + clave_depto + "','" + clave_frecuencia_pago + "','" + num_reg_patronal + "','" + forma_pago + "','" + contrato + "','" + jornada + "','" + regimen_fiscal + "','" + fecha_ingreso + "','" + estatus + "','" + tipo_salario + "','" + salario_diario + "','" + salario_integrado + "','" + rfc + "','" + curp + "','" + registro_imss + "','" + direccion + "','" + cp + "','" + contratosat + "')");

                if (comando.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Conexion correcta");

                }
                else
                {
                    MessageBox.Show("Error al probar conexiòn");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                throw;
            }

        }

        public ArrayList datosempleado()
        {

            SqlTransaction  trODBC;
            try
            {
                
                
                System.Text.StringBuilder strQuery = new System.Text.StringBuilder();
                this.m_ConnODBC2009 = new SqlConnection (conexionSQL);
                this.m_ConnODBC2009.Open();
                trODBC = m_ConnODBC2009.BeginTransaction(IsolationLevel.RepeatableRead);
                SqlCommand commODBC = new SqlCommand("",m_ConnODBC2009, trODBC);
                
                strQuery.Remove(0, 0);
                strQuery.Append("SELECT numero as numero,nombres as nombre ,apellido_paterno as app ,apellido_materno as apm  ,clave_puesto as cpt ,clave_depto as cld ,clave_frecuencia_pago as clfp ,num_reg_patronal as numrp ,forma_pago as formap ,contrato as contrato ,jornada as jornada ,regimen_fiscal as regimenf ,fecha_ingreso as fechai ,estatus as estatus  ,tipo_salario as tipos ,salario_diario as sald ,salario_integrado as sali ,rfc as rfc ,curp as curp ,registro_imss as regimss,direccion as direccion,cp as cp, contrato_sat as contratosat FROM usuario ");
                commODBC.CommandText = strQuery.ToString();
                SqlDataReader OdbcDr = commODBC.ExecuteReader();
                
                
             
                while (OdbcDr.Read())
                {
                    Vempleados c = new Vempleados();

                    c.numero = Convert.ToString(OdbcDr["numero"]);
                    c.nombres = Convert.ToString(OdbcDr["nombre"]);
                    c.apellido_paterno = Convert.ToString(OdbcDr["app"]);
                    c.apellido_pmaterno = Convert.ToString(OdbcDr["apm"]);
                    c.clavepuesto = Convert.ToString(OdbcDr["cpt"]);
                    c.clavedepto = Convert.ToString(OdbcDr["cld"]);
                    c.clavefrecuenciapago = Convert.ToString(OdbcDr["clfp"]);
                    c.regpatronal = Convert.ToString(OdbcDr["numrp"]);
                    c.formapago = Convert.ToString(OdbcDr["formap"]);
                    c.contrato = Convert.ToString(OdbcDr["contrato"]);
                    c.jornada = Convert.ToString(OdbcDr["jornada"]);
                    c.regimenfiscal = Convert.ToString(OdbcDr["regimenf"]);
                    c.fechaingreso = Convert.ToString(OdbcDr["fechai"]);
                    c.estatus = Convert.ToString(OdbcDr["estatus"]);
                    c.tiposalario = Convert.ToString(OdbcDr["tipos"]);
                    c.salariodiario = Convert.ToString(OdbcDr["sald"]);
                    c.salariointegrado = Convert.ToString(OdbcDr["sali"]);
                    c.rfc = Convert.ToString(OdbcDr["rfc"]);
                    c.curp = Convert.ToString(OdbcDr["curp"]);
                    c.registroimss = Convert.ToString(OdbcDr["regimss"]);
                    c.direccion = Convert.ToString(OdbcDr["direccion"]);
                    if (c.direccion == "CIUDAD DE MEXICO" | c.direccion == "MEXICO")
                    {
                        c.direccion = "DIF";
                    }
                   if (c.direccion == "PUEBLA")
                    {
                        c.direccion = "PUE";
                    }
                    if (c.direccion == "OAXACA")
                    {
                        c.direccion = "OAX";
                    }

                   c.cp = Convert.ToString(OdbcDr["cp"]);
                    c.contratosat = Convert.ToString(OdbcDr["contratosat"]);
                    c.mensaje = c.numero + "," + c.nombres + "," + c.apellido_paterno + "," + c.apellido_pmaterno + "," + c.clavepuesto + "," + c.clavedepto + "," + c.clavefrecuenciapago + "," + c.regpatronal + "," + c.formapago + "," + c.contrato + "," + c.jornada + "," + c.regimenfiscal + "," + c.fechaingreso + "," + c.estatus + "," + c.tiposalario + "," + c.salariodiario + "," + c.salariointegrado + "," + c.rfc + "," + c.curp + "," + c.registroimss + "," + c.direccion + "," + c.cp + "," + c.contratosat;
                    arreDatos.Add(c);
                }

                this.m_ConnODBC2009.Close();
                OdbcDr.Close();


                return arreDatos;
            }
            catch (Exception ex)
            {

                throw;
            }


        }

    }
}
