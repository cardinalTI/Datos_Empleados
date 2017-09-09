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
                    DGVreporte.Rows[i].Cells[27].Value = ((rnomina)this.arreCalculos[i]).Descanso_laborado + ((rnomina)this.arreCalculos[i]).Descanso_laborado1 ;
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
            catch (Exception)
            {

                throw;
            }
        }

        private void BTNexpo_Click(object sender, EventArgs e)
        {
           
        }
    }
    
}
