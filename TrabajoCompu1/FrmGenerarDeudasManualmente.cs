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
    public partial class FrmGenerarDeudasManualmente : Form
    {

        AlgoritmoPadre obj = new AlgoritmoPadre();
        public FrmGenerarDeudasManualmente()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           if(txtDeuda.Text!=""&&txtDNI.Text!="")
            {
                Deudor objaux = new Deudor();
                objaux.DNI = Convert.ToInt32(txtDNI.Text);
                objaux.DEUDA = Convert.ToInt32(txtDeuda.Text);
                if (obj.ExisteDNI(objaux.DNI) == true)
                {
                    MessageBox.Show("El DNI ya existe");
                    txtDeuda.Clear();
                    txtDNI.Clear();
                }
                else
                {
                    obj.AgregarDatosManualmente(objaux);
                    MessageBox.Show("Datos agregados correctamente");
                    txtDeuda.Clear();
                    txtDNI.Clear();
                }
            }
            else
            {
                MessageBox.Show("Complete los recuadros");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
