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
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void BTNDempleados_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            p.Show();
        }

        private void BTNreportes_Click(object sender, EventArgs e)
        {
            reporte r = new reporte();
            r.Show();
        }
    }
}
