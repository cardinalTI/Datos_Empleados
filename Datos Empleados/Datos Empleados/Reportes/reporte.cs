using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos_Empleados
{
    public partial class reporte : Form
    {
        MRnomina rnomina = new MRnomina();
        private ArrayList arreCalculos = new ArrayList();
        rnomina c = new rnomina();
        suanomina s = new suanomina();
        public reporte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conexion = CBXempresa.Text;
            
            string RC = rnomina.conexiofinal(conexion);

            ///mostrar la vista y generar el metodo de peugeot
            if (CBXempresa.Text == "PEUGEOT")
            {
                panelnomina.Visible = false;
                panelpeugeot.Visible = true;

                try
                {
                    this.DGVpeugeot.Rows.Clear();
                    this.arreCalculos = rnomina.ObtenerCalculoNominaP(dateTimePicker1.Value, RC);
                    for (int i = 0; i < this.arreCalculos.Count; i++)
                    {
                        this.DGVpeugeot.Rows.Add(c);
                        
                        //llenar el datagrid de peugeot
                        DGVreporte.Rows[i].Cells[0].Value = ((rnomina)this.arreCalculos[i]).NOMBREP;
                        DGVreporte.Rows[i].Cells[1].Value = ((rnomina)this.arreCalculos[i]).CUOTADIARIAP;
                        DGVreporte.Rows[i].Cells[2].Value = ((rnomina)this.arreCalculos[i]).diasP;
                        DGVreporte.Rows[i].Cells[3].Value = ((rnomina)this.arreCalculos[i]).sueldoP;
                        DGVreporte.Rows[i].Cells[4].Value = ((rnomina)this.arreCalculos[i]).otrosingP;
                        DGVreporte.Rows[i].Cells[5].Value = ((rnomina)this.arreCalculos[i]).fondodeahorroP;
                        DGVreporte.Rows[i].Cells[6].Value = " ";
                        DGVreporte.Rows[i].Cells[7].Value = ((rnomina)this.arreCalculos[i]).valesdedespensaP;
                        DGVreporte.Rows[i].Cells[8].Value = ((rnomina)this.arreCalculos[i]).subsidioalempleoP;
                        DGVreporte.Rows[i].Cells[9].Value = ((rnomina)this.arreCalculos[i]).totalpercepcionesP;
                        DGVreporte.Rows[i].Cells[10].Value = ((rnomina)this.arreCalculos[i]).retencionimssP;
                        DGVreporte.Rows[i].Cells[11].Value = ((rnomina)this.arreCalculos[i]).retencionisrP;
                        DGVreporte.Rows[i].Cells[12].Value = ((rnomina)this.arreCalculos[i]).valesdedespensadP;
                        DGVreporte.Rows[i].Cells[13].Value = ((rnomina)this.arreCalculos[i]).fondodeahorroemp;
                        DGVreporte.Rows[i].Cells[14].Value = ((rnomina)this.arreCalculos[i]).fondodeahorropaP;
                        DGVreporte.Rows[i].Cells[15].Value = ((rnomina)this.arreCalculos[i]).amortizacionP;
                        DGVreporte.Rows[i].Cells[16].Value = ((rnomina)this.arreCalculos[i]).totaldP;
                        DGVreporte.Rows[i].Cells[17].Value = ((rnomina)this.arreCalculos[i]).ingresonetoP;
                        DGVreporte.Rows[i].Cells[18].Value = " ";
                        DGVreporte.Rows[i].Cells[19].Value = ((rnomina)this.arreCalculos[i]).aguinaldo15P;
                        DGVreporte.Rows[i].Cells[20].Value = ((rnomina)this.arreCalculos[i]).aguinaldo30P;
                        DGVreporte.Rows[i].Cells[21].Value = ((rnomina)this.arreCalculos[i]).primav25P;
                        DGVreporte.Rows[i].Cells[22].Value = ((rnomina)this.arreCalculos[i]).primav70P;
                        DGVreporte.Rows[i].Cells[23].Value = ((rnomina)this.arreCalculos[i]).vales10P;
                        DGVreporte.Rows[i].Cells[24].Value = ((rnomina)this.arreCalculos[i]).fondo13P;
                        DGVreporte.Rows[i].Cells[25].Value = ((rnomina)this.arreCalculos[i]).totalpresP;
                        DGVreporte.Rows[i].Cells[26].Value = " ";
                        DGVreporte.Rows[i].Cells[27].Value = ((rnomina)this.arreCalculos[i]).totalimpuesto;
                        DGVreporte.Rows[i].Cells[28].Value = ((rnomina)this.arreCalculos[i]).costosisnP;
                        DGVreporte.Rows[i].Cells[29].Value = " ";
                        DGVreporte.Rows[i].Cells[30].Value = ((rnomina)this.arreCalculos[i]).costopatronalP;
                        DGVreporte.Rows[i].Cells[31].Value = ((rnomina)this.arreCalculos[i]).comisionP;
                        DGVreporte.Rows[i].Cells[32].Value = " ";
                        DGVreporte.Rows[i].Cells[33].Value = ((rnomina)this.arreCalculos[i]).subtP;
                        DGVreporte.Rows[i].Cells[34].Value = ((rnomina)this.arreCalculos[i]).ivaP;
                        DGVreporte.Rows[i].Cells[35].Value = ((rnomina)this.arreCalculos[i]).totalP;
                        DGVreporte.Rows[i].Cells[36].Value = " ";
                        DGVreporte.Rows[i].Cells[37].Value = ((rnomina)this.arreCalculos[i]).banco;
                        DGVreporte.Rows[i].Cells[38].Value = ((rnomina)this.arreCalculos[i]).cuenta;
                        DGVreporte.Rows[i].Cells[39].Value = ((rnomina)this.arreCalculos[i]).clabeP;


                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show("Se presento el siguiente error " + a);
                    throw;
                }
            }
            ///mostrar la vista y generar el metodo de foldur
            else
            {
                panelnomina.Visible =true;
                panelpeugeot.Visible = false;

                try
                {
                    this.DGVreporte.Rows.Clear();
                    this.arreCalculos = rnomina.ObtenerCalculoNomina(dateTimePicker1.Value, RC);
                    for (int i = 0; i < this.arreCalculos.Count; i++)
                    {


                        this.DGVreporte.Rows.Add(c);
                        DGVreporte.Rows[i].Cells[0].Value = ((rnomina)this.arreCalculos[i]).centro;
                        DGVreporte.Rows[i].Cells[1].Value = ((rnomina)this.arreCalculos[i]).departartamento;
                        DGVreporte.Rows[i].Cells[2].Value = ((rnomina)this.arreCalculos[i]).puesto;
                        DGVreporte.Rows[i].Cells[3].Value = ((rnomina)this.arreCalculos[i]).empleado;
                        DGVreporte.Rows[i].Cells[4].Value = ((rnomina)this.arreCalculos[i]).rfc;
                        DGVreporte.Rows[i].Cells[5].Value = ((rnomina)this.arreCalculos[i]).nss;
                        DGVreporte.Rows[i].Cells[6].Value = ((rnomina)this.arreCalculos[i]).curp;
                        DGVreporte.Rows[i].Cells[7].Value = ((rnomina)this.arreCalculos[i]).fecha_alta;
                        DGVreporte.Rows[i].Cells[8].Value = ((rnomina)this.arreCalculos[i]).nombre;
                        DGVreporte.Rows[i].Cells[10].Value = ((rnomina)this.arreCalculos[i]).sueldodiario;
                        DGVreporte.Rows[i].Cells[11].Value = ((rnomina)this.arreCalculos[i]).sdi;
                        DGVreporte.Rows[i].Cells[12].Value = ((rnomina)this.arreCalculos[i]).dias_laborados;
                        DGVreporte.Rows[i].Cells[13].Value = ((rnomina)this.arreCalculos[i]).dias_laboradosreales;
                        DGVreporte.Rows[i].Cells[14].Value = ((rnomina)this.arreCalculos[i]).dias_faltas;
                        DGVreporte.Rows[i].Cells[17].Value = ((rnomina)this.arreCalculos[i]).descuentop_aldia;
                        DGVreporte.Rows[i].Cells[18].Value = ((rnomina)this.arreCalculos[i]).faltas;
                        DGVreporte.Rows[i].Cells[19].Value = ((rnomina)this.arreCalculos[i]).diasIncEnfGral;
                        DGVreporte.Rows[i].Cells[20].Value = ((rnomina)this.arreCalculos[i]).diasmaternidad;
                        DGVreporte.Rows[i].Cells[21].Value = ((rnomina)this.arreCalculos[i]).diasIncTrayecto;
                        DGVreporte.Rows[i].Cells[22].Value = ((rnomina)this.arreCalculos[i]).sueldo;
                        DGVreporte.Rows[i].Cells[23].Value = ((rnomina)this.arreCalculos[i]).OtrosIngresosGravados;
                        DGVreporte.Rows[i].Cells[24].Value = ((rnomina)this.arreCalculos[i]).OtrosIngresosExento;
                        DGVreporte.Rows[i].Cells[25].Value = ((rnomina)this.arreCalculos[i]).primaVacacional;
                        DGVreporte.Rows[i].Cells[26].Value = ((rnomina)this.arreCalculos[i]).diaFestivo;
                        DGVreporte.Rows[i].Cells[27].Value = ((rnomina)this.arreCalculos[i]).Descanso_laborado + ((rnomina)this.arreCalculos[i]).Descanso_laborado1;
                        DGVreporte.Rows[i].Cells[28].Value = ((rnomina)this.arreCalculos[i]).primaDominical;
                        DGVreporte.Rows[i].Cells[29].Value = ((rnomina)this.arreCalculos[i]).Bonos;
                        DGVreporte.Rows[i].Cells[30].Value = ((rnomina)this.arreCalculos[i]).horasExtra;
                        DGVreporte.Rows[i].Cells[31].Value = ((rnomina)this.arreCalculos[i]).sudsidioapraelempleopagado;
                        DGVreporte.Rows[i].Cells[32].Value = ((rnomina)this.arreCalculos[i]).totalpercepciones;
                        DGVreporte.Rows[i].Cells[33].Value = ((rnomina)this.arreCalculos[i]).impuestoretenido;
                        DGVreporte.Rows[i].Cells[34].Value = ((rnomina)this.arreCalculos[i]).ISR_ANUAL;
                        DGVreporte.Rows[i].Cells[35].Value = ((rnomina)this.arreCalculos[i]).imss;
                        DGVreporte.Rows[i].Cells[36].Value = ((rnomina)this.arreCalculos[i]).DescCreditoInfonavit;
                        DGVreporte.Rows[i].Cells[37].Value = ((rnomina)this.arreCalculos[i]).AjusteDifInfonavit;
                        DGVreporte.Rows[i].Cells[38].Value = ((rnomina)this.arreCalculos[i]).Descuento_fonacot;
                        DGVreporte.Rows[i].Cells[39].Value = ((rnomina)this.arreCalculos[i]).otrosdescuentos;
                        DGVreporte.Rows[i].Cells[40].Value = ((rnomina)this.arreCalculos[i]).pension_alimenticia;
                        DGVreporte.Rows[i].Cells[41].Value = ((rnomina)this.arreCalculos[i]).descuentofaltas;
                        DGVreporte.Rows[i].Cells[42].Value = ((rnomina)this.arreCalculos[i]).totaldeducciones;
                        DGVreporte.Rows[i].Cells[43].Value = ((rnomina)this.arreCalculos[i]).netopagar;
                        DGVreporte.Rows[i].Cells[44].Value = ((rnomina)this.arreCalculos[i]).isn;
                        DGVreporte.Rows[i].Cells[45].Value = ((rnomina)this.arreCalculos[i]).sua;
                        DGVreporte.Rows[i].Cells[46].Value = ((rnomina)this.arreCalculos[i]).cargasocial;
                        DGVreporte.Rows[i].Cells[47].Value = ((rnomina)this.arreCalculos[i]).cuenta;
                        DGVreporte.Rows[i].Cells[48].Value = ((rnomina)this.arreCalculos[i]).banco;
                        DGVreporte.Rows[i].Cells[49].Value = ((rnomina)this.arreCalculos[i]).clabe;
                        DGVreporte.Rows[i].Cells[50].Value = ((rnomina)this.arreCalculos[i]).sueldomensual;
                        DGVreporte.Rows[i].Cells[51].Value = ((rnomina)this.arreCalculos[i]).vacaciones;
                        DGVreporte.Rows[i].Cells[52].Value = ((rnomina)this.arreCalculos[i]).primavacacional2;
                        DGVreporte.Rows[i].Cells[53].Value = ((rnomina)this.arreCalculos[i]).aguinaldo;
                        DGVreporte.Rows[i].Cells[54].Value = ((rnomina)this.arreCalculos[i]).totalpasivolaboral;


                    }

                }
                catch (Exception b)
                {
                    MessageBox.Show("Se presento el siguiente error" + b);
                    throw;
                }

            }
          
        }

        //Exportar datos a excel
        private void BTNexpo_Click(object sender, EventArgs e)
        {
           
            exporta_a_excel();
        }

        public void exporta_a_excel()

        {
            if ((CBXempresa.Text == "PEUGEOT"))
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(true);
                int ColumnIndex = 0;

                foreach (DataGridViewColumn col in DGVpeugeot.Columns)
                {
                    ColumnIndex++;
                    excel.Cells[1, ColumnIndex] = col.HeaderText;
                }
                int rowIndex = 0;
                //barra
                progressBar1.Maximum = this.DGVpeugeot.Rows.Count;
                progressBar1.Minimum = 1;


                //barra
                foreach (DataGridViewRow row in DGVpeugeot.Rows)
                {
                    rowIndex++;
                    ColumnIndex = 0;

                    foreach (DataGridViewColumn col in DGVpeugeot.Columns)
                    {
                        ColumnIndex++;
                        excel.Cells[rowIndex + 1, ColumnIndex] = row.Cells[col.Name].Value;
                        progressBar1.Value = rowIndex;
                        progressBar1.PerformStep();
                        label3.Text = "Total de filas exportadas " + progressBar1.Value.ToString() + " de " + progressBar1.Maximum.ToString();
                      
                    }
                }
                MessageBox.Show("El archivo de excel se creo correctamente ");
                excel.Visible = true;
                Worksheet worksheet = (Worksheet)excel.ActiveSheet;
                worksheet.Activate();
            }

            else
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(true);
                int ColumnIndex = 0;

                foreach (DataGridViewColumn col in DGVreporte.Columns)
                {
                    ColumnIndex++;
                    excel.Cells[1, ColumnIndex] = col.HeaderText;
                }
                int rowIndex = 0;
                //barra
                progressBar1.Maximum = this.DGVreporte.Rows.Count;
                progressBar1.Minimum = 1;


                //barra
                foreach (DataGridViewRow row in DGVreporte.Rows)
                {
                    rowIndex++;
                    ColumnIndex = 0;

                    foreach (DataGridViewColumn col in DGVreporte.Columns)
                    {
                        ColumnIndex++;
                        excel.Cells[rowIndex + 1, ColumnIndex] = row.Cells[col.Name].Value;
                        progressBar1.Value = rowIndex;
                        progressBar1.PerformStep();
                        label3.Text = "Total de filas exportadas " + progressBar1.Value.ToString() + " de " + progressBar1.Maximum.ToString();
                        
                    }
                }
                MessageBox.Show("El archivo de excel se creo correctamente ");
                excel.Visible = true;
                Worksheet worksheet = (Worksheet)excel.ActiveSheet;
                worksheet.Activate();
            }

        }

        private void reporte_Load(object sender, EventArgs e)
        {
            panelnomina.Visible = true;
            panelpeugeot.Visible = false;
            
        }

        private void nominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelnomina.Visible = true;
            panelpeugeot.Visible = false;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

}
