using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercioExterior
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnManCliente_Click(object sender, EventArgs e)
        {
            frmClientes frmClientes = new frmClientes();
            frmClientes.ShowDialog();
        }

        private void btnManPuertos_Click(object sender, EventArgs e)
        {
            frmPuertos frmPuertos = new frmPuertos();
            frmPuertos.ShowDialog();
        }

        private void btnTransacciones_Click(object sender, EventArgs e)
        {
            frmTransaccion  transaccion = new frmTransaccion();
            transaccion.ShowDialog();
        }
    }
}
