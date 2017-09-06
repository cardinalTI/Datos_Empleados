using System;
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
        public reporte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conexion = CBXempresa.Text;
            
            string RC = rnomina.conexiofinal(conexion);

            rnomina.CalculoNomina(RC);
        }
    }
}
