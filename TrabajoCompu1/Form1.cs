using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoCompu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generarDeudasBancariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGenerarDeudas frm = new FrmGenerarDeudas();
            frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por su visita");
            Close();
        }

        private void ordenarDeudasPorInserciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrdenarPorInsercion frm = new FrmOrdenarPorInsercion();
            frm.ShowDialog();
        }

        private void ordenarDeudasPorShellSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrdenarPorShell frm = new FrmOrdenarPorShell();
            frm.ShowDialog();
        }
    }
}
