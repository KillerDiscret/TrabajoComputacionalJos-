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
    public partial class FrmGenerarDeudas : Form
    {
        AlgoritmoPadre obj = new AlgoritmoPadre();
        public FrmGenerarDeudas()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            obj.GenerarDatos();
            lBDeudas.DisplayMember = "DEUDA";
            lBDeudas.DataSource = AlgoritmoPadre.Deudores;
            lBDni.DisplayMember = "DNI";
            lBDni.DataSource = AlgoritmoPadre.Deudores;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
