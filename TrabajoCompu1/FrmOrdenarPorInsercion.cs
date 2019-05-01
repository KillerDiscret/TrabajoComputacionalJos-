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
    public partial class FrmOrdenarPorInsercion : Form
    {
        AlgoritmoPadre obj = new AlgoritmoPadre();
        public FrmOrdenarPorInsercion()
        {
            InitializeComponent();
        }

        private void FrmOrdenarPorInsercion_Load(object sender, EventArgs e)
        {
            /* lBDeudas.DisplayMember = "DEUDA";
             lBDeudas.DataSource = AlgoritmoPadre.Deudores;
             lBDni.DisplayMember = "DNI";
             lBDni.DataSource = AlgoritmoPadre.Deudores;
     */
            foreach (Deudor x in AlgoritmoPadre.Deudores)
            {
                lBDeudas.Items.Add(x.DEUDA);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           lBDeudas.Items.Clear();

            int []auxdeudas = obj.OrdenarPorInsercion();

            for (int i = 0; i < 1000; i++)
            {
                lBDeudas.Items.Add(auxdeudas[i]);
              
            }
        
            for (int i=0; i<1000;i++)
            {
                List<Deudor> listadeudores = AlgoritmoPadre.Deudores.FindAll(delegate (Deudor x) { return x.DEUDA == auxdeudas[i]; });
                foreach (Deudor aux in listadeudores)
                {
                    if(lbDni.Items.Equals(aux.DNI)==false)
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
    }
}
