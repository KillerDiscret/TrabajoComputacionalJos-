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
    public partial class FrmOrdenarPorShell : Form
    {

        AlgoritmoPadre obj = new AlgoritmoPadre();
        public FrmOrdenarPorShell()
        {
            InitializeComponent();
        }
        //se agrego de casualidad
        private void label2_Click(object sender, EventArgs e)
        {
           
        }
        //se agrego de casualidad
        private void button1_Click(object sender, EventArgs e)
        {
            lbDeudas.Items.Clear();
            int[] auxdeudas = obj.OrdenarPorShell();

            for (int i = 0; i < 1000; i++)
            {
                lbDeudas.Items.Add(auxdeudas[i]);

            }

            for (int i = 0; i < 1000; i++)
            {
                List<Deudor> listadeudores = AlgoritmoPadre.Deudores.FindAll(delegate (Deudor x) { return x.DEUDA == auxdeudas[i]; });
                foreach (Deudor aux in listadeudores)
                {
                    if (lbDni.Items.Equals(aux.DNI) == false)
                    {
                        lbDni.Items.Add(aux.DNI);
                    }
                }
            }






        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmOrdenarPorShell_Load(object sender, EventArgs e)
        {
            foreach (Deudor x in AlgoritmoPadre.Deudores)
            {
                lbDeudas.Items.Add(x.DEUDA);
            }
        }
    }
}
