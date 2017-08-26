using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos_Empleados
{
    public partial class Principal : Form
    {
        Malta_empleados alta = new Malta_empleados() ;
        Vempleados empleados = new Vempleados ();
        Mbaja_Empleados baja = new Mbaja_Empleados();
        Msueldo_empleado sueldo = new Msueldo_empleado();
        Mcuentas cuentas = new Mcuentas();

     
      

        string texto;
        private ArrayList arreDatos;
        int contador;
        string empleado;
        string registro;
        public Principal()
        {
            InitializeComponent();
        }


        //Visibilidad de los paneles
        private void Form1_Load(object sender, EventArgs e)
        {
            panel_alta_empleados.Visible = false;
            panel_baja_empleados.Visible = false;
            panel_salario.Visible = false;
            panel_cuentas.Visible = false;
            panel_departamento.Visible = false;
        }

        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_alta_empleados.Visible = true;
            panel_baja_empleados.Visible = false;
            panel_salario.Visible = false;
            panel_cuentas.Visible = false;
            panel_departamento.Visible = false;
        }

        private void bajaEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_alta_empleados.Visible = false;
            panel_baja_empleados.Visible = true;
            panel_salario.Visible = false;
            panel_cuentas.Visible = false;
            panel_departamento.Visible = false;
        }


        private void cambioDeSalarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_salario.Visible = true;
            panel_alta_empleados.Visible = false;
            panel_baja_empleados.Visible = false;
            panel_cuentas.Visible = false;
            panel_departamento.Visible = false;
        }

        private void cuentasDeBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_cuentas.Visible = true;
            panel_salario.Visible = false;
            panel_alta_empleados.Visible = false;
            panel_baja_empleados.Visible = false;
            panel_departamento.Visible = false;

        }

        private void agregarDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_departamento.Visible = true;
            panel_cuentas.Visible = false;
            panel_salario.Visible = false;
            panel_alta_empleados.Visible = false;
            panel_baja_empleados.Visible = false;

        }

        //Ingreso de empleados
        private void BTNIempleados_Click(object sender, EventArgs e)
        {
            
            try
            {
                OpenFileDialog openfile1 = new OpenFileDialog();
                if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    
                    texto = openfile1.FileName;
                }
                {
                    string pathconn = "Provider = Microsoft.jet.OLEDB.4.0; Data source=" + texto + ";Extended Properties=\"Excel 8.0;HDR= yes;\";";
                    OleDbConnection conn = new OleDbConnection(pathconn);
                    OleDbDataAdapter MyDataAdapter = new OleDbDataAdapter("Select  [numero],[nombre],[apellido_paterno],[apellido_materno],[clave_puesto],[clave_depto],[clave_frecuencia_pago],[num_reg_patronal],[forma_pago],[contrato],[jornada],[regimen_fiscal],[fecha_ingreso],[estatus],[tipo_salario],[salario_diario],[salario_integrado],[rfc],[curp],[reg_imss],[dirección],[cp],[contrato_sat]  from [alta_empleado$]", conn);
                    DataTable dt = new DataTable();
                    MyDataAdapter.Fill(dt);
                    DGVAempleados.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void BTNGempleadostxt_Click(object sender, EventArgs e)
        {
            alta.eliminar();



            try
            {
                foreach (DataGridViewRow row in DGVAempleados.Rows)
                    alta.cargar(
                         Convert.ToString(row.Cells[0].Value),
                         Convert.ToString(row.Cells[1].Value),
                         Convert.ToString(row.Cells[2].Value),
                         Convert.ToString(row.Cells[3].Value),
                         Convert.ToString(row.Cells[4].Value),
                         Convert.ToString(row.Cells[5].Value),
                         Convert.ToString(row.Cells[6].Value),
                         Convert.ToString(row.Cells[7].Value),
                         Convert.ToString(row.Cells[8].Value),
                         Convert.ToString(row.Cells[9].Value),
                         Convert.ToString(row.Cells[10].Value),
                         Convert.ToString(row.Cells[11].Value),
                         Convert.ToString(row.Cells[12].Value),
                         Convert.ToString(row.Cells[13].Value),
                         Convert.ToString(row.Cells[14].Value),
                         Convert.ToString(row.Cells[15].Value),
                         Convert.ToString(row.Cells[16].Value),
                         Convert.ToString(row.Cells[17].Value),
                         Convert.ToString(row.Cells[18].Value),
                         Convert.ToString(row.Cells[19].Value),
                         Convert.ToString(row.Cells[20].Value),
                         Convert.ToString(row.Cells[21].Value),
                         Convert.ToString(row.Cells[22].Value)

                         );


                MessageBox.Show("Empleados Guardados correctamente en la base");
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MuestraDatos();
            pasarTXT();

        }


        public void MuestraDatos()
        {

            try
            {
                this.arreDatos = this.alta.datosempleado ();
                this.dataGridView1.Rows.Clear();
                
                if (this.arreDatos.Count > 0)
                {
                    for (int i = 0; i < this.arreDatos.Count; i++)
                    {
                        this.dataGridView1.Rows.Add();
                        this.dataGridView1.Rows[i].Cells[0].Value = ((Vempleados)this.arreDatos[i]).mensaje;
                       
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al retomar los datos");
                throw;
            }

        }

        public void pasarTXT()
        {
            if (!Directory.Exists(@"c:\exportaciones"))
            {
                Directory.CreateDirectory(@"C:\exportaciones");
            }

            TextWriter sw = new StreamWriter(@"C:\exportaciones\Empleados.txt");
            int rowcount = dataGridView1.Rows.Count;
            for (int i = 0; i < rowcount - 1; i++)
            {
                sw.WriteLine(dataGridView1.Rows[i].Cells[0].Value.ToString() + "\t");
                             
                              
            }
            sw.Close();
            MessageBox.Show("Datos Exportados correctamente");
        }


        //Baja de empleados
        private void BTNIbajas_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openfile1 = new OpenFileDialog();
                if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    texto = openfile1.FileName;
                }
                {
                    string pathconn = "Provider = Microsoft.jet.OLEDB.4.0; Data source=" + texto + ";Extended Properties=\"Excel 8.0;HDR= yes;\";";
                    OleDbConnection conn = new OleDbConnection(pathconn);
                    OleDbDataAdapter MyDataAdapter = new OleDbDataAdapter("Select [numero],[Registro_patronal],[Tipo],[Fecha],[Causa_baja] from [bajas_empleado$]", conn);
                    DataTable dt = new DataTable();
                    MyDataAdapter.Fill(dt);
                    DGVbajas .DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void BTNBbajas_Click(object sender, EventArgs e)
        {
          string conexion= CBXbajas.Text;
            

          string RC = baja.conexiofinal(conexion);
            try
            {
                foreach (DataGridViewRow row in DGVbajas.Rows)
                {

                    empleado = baja.buscarempleado(Convert.ToString(row.Cells[0].Value), RC);
                    if (empleado != "" )
                    {
                    registro = baja.buscarRegistro(Convert.ToString(row.Cells[1].Value), RC);
                    if (registro != "")
                    {
                        baja.cargar(empleado, registro, Convert.ToString(row.Cells[2].Value), Convert.ToString(row.Cells[3].Value), Convert.ToString(row.Cells[4].Value),RC);
                        contador ++;
                    }
                    }

                }
                
                MessageBox.Show("Empleados Dados de Baja  Correctamente ");
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //sueldo empleados
        private void BTNIsueldos_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openfile1 = new OpenFileDialog();
                if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    texto = openfile1.FileName;
                }
                {
                    string pathconn = "Provider = Microsoft.jet.OLEDB.4.0; Data source=" + texto + ";Extended Properties=\"Excel 8.0;HDR= yes;\";";
                    OleDbConnection conn = new OleDbConnection(pathconn);
                    OleDbDataAdapter MyDataAdapter = new OleDbDataAdapter("Select [numero],[Registro_patronal],[Tipo],[Fecha],[Salario_hora],[Salario_diario],[Salario_integrado] from [sueldos_empleado$]", conn);
                    DataTable dt = new DataTable();
                    MyDataAdapter.Fill(dt);
                    DGVAsueldo.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void BTNAsueldos_Click(object sender, EventArgs e)
        {
            string conexion = CBXAsueldos.Text;


           string  RC = sueldo.conexiofinal(conexion);
            try
            {
                foreach (DataGridViewRow row in DGVAsueldo.Rows)
                {

                    empleado = sueldo.buscarempleado(Convert.ToString(row.Cells[0].Value), RC);
                    if (empleado != "")
                    {
                        registro = sueldo.buscarRegistro(Convert.ToString(row.Cells[1].Value), RC);
                        if (registro != "")
                        {
                            sueldo.cargarsueldos(empleado, registro, Convert.ToString(row.Cells[2].Value), Convert.ToString(row.Cells[3].Value), Convert.ToString(row.Cells[4].Value), Convert.ToString(row.Cells[5].Value), Convert.ToString(row.Cells[6].Value), RC);
                            contador++;
                        }
                    }

                }

                MessageBox.Show("Empleados Dados de Baja  Correctamente ");
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Cuentas Empleados
        private void BTNIcuentas_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openfile1 = new OpenFileDialog();
                if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    texto = openfile1.FileName;
                }
                {
                    string pathconn = "Provider = Microsoft.jet.OLEDB.4.0; Data source=" + texto + ";Extended Properties=\"Excel 8.0;HDR= yes;\";";
                    OleDbConnection conn = new OleDbConnection(pathconn);
                    OleDbDataAdapter MyDataAdapter = new OleDbDataAdapter("Select [Empleado],[Cuenta],[Banco] from [cuentas_empleado$]", conn);
                    DataTable dt = new DataTable();
                    MyDataAdapter.Fill(dt);
                    DGVcuentas.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void BTNAcuentas_Click(object sender, EventArgs e)
        {
            string conexion = CBXcuentas.Text;


            string RC = cuentas.conexiofinal(conexion);
            try
            {
                foreach (DataGridViewRow row in DGVAsueldo.Rows)
                {
                     cuentas.cargarcuentas(Convert.ToString(row.Cells[0].Value), Convert.ToString(row.Cells[1].Value), RC);
                    cuentas.cargarbancos(Convert.ToString(row.Cells[0].Value), Convert.ToString(row.Cells[2].Value), RC,CBXcuentas.Text);
                     contador++;
                        
                }

                MessageBox.Show("Empleados Dados de Baja  Correctamente ");
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openfile1 = new OpenFileDialog();
                if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    texto = openfile1.FileName;
                }
                {
                    string pathconn = "Provider = Microsoft.jet.OLEDB.4.0; Data source=" + texto + ";Extended Properties=\"Excel 8.0;HDR= yes;\";";
                    OleDbConnection conn = new OleDbConnection(pathconn);
                    OleDbDataAdapter MyDataAdapter = new OleDbDataAdapter("Select [nombre],[clave] from [departamentos_empleado$]", conn);
                    DataTable dt = new DataTable();
                    MyDataAdapter.Fill(dt);
                    DGVIdepartamento.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
    }
}
