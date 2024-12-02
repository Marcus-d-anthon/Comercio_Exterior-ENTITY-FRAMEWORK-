using ComercioExterior.Context;
using ComercioExterior.Modelo;
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
    public partial class frmTransaccion : Form
    {
        public int IdTransaccion = 0;
        public frmTransaccion()
        {
            InitializeComponent();
            cmbTTransaccion.Items.Add("Importación");
            cmbTTransaccion.Items.Add("Exportación");
        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmBuscador buscador = new frmBuscador();
                buscador.tipo = "C";
                buscador.filtro = txtCliente.Text;
                buscador.ShowDialog();
                txtCliente.Text = buscador.respuesta1;
                txtNombreCliente.Text = buscador.respuesta2;
            }
        }

        private void txtPuerto_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                frmBuscador buscador = new frmBuscador();
                buscador.tipo = "P";
                buscador.filtro = txtPuerto.Text;
                buscador.ShowDialog();
                txtPuerto.Text = buscador.respuesta1;
                txtDescripcionPuerto.Text = buscador.respuesta2;
            }
        }

        private void cmbTTransaccion_Click(object sender, EventArgs e)
        {
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (IdTransaccion == 0)
            {
                Transaccion objTransaccion = new Transaccion();
                objTransaccion.IdCliente = int.Parse(txtCliente.Text);
                objTransaccion.IdPuerto = int.Parse(txtPuerto.Text);
                objTransaccion.TipoTransaccion = cmbTTransaccion.SelectedItem.ToString();
                objTransaccion.Comentario = TXT;
                objTransaccion.Costo = decimal.Parse(txtCosto.Text);
                objTransaccion.Estado = "A";

                Utiles.context.Transaccions.Add(objTransaccion);
                Utiles.context.SaveChanges();

                txtID.Text = objTransaccion.Id.ToString();
                MessageBox.Show($"Tra {objTransaccion.Id} creado con éxito");
                this.Close();
            }
        }
    }
}
