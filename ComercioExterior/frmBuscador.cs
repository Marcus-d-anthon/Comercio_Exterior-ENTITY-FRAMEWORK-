using ComercioExterior.Context;
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
    public partial class frmBuscador : Form
    {
        public string tipo = "";
        public string filtro = "";
        public string respuesta1 = "";
        public string respuesta2 = "";

        public frmBuscador()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            txtFiltro.Text = filtro;
            this.Close();
        }

        private void frmBuscador_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }

        private void cargarGrid()
        {
            if (tipo == "C")
            {
                cargarClientes();
            }
            else if (tipo == "P")
            {
                cargarPuertos();
            }
        }

        private void cargarPuertos()
        {
            var listaPuertos = Utiles.context.Puertos.Where(x => x.Estado == "A" && (x.Descripcion.ToUpper().Contains(txtFiltro.Text)
                || x.Codigo.ToUpper().Contains(txtFiltro.Text) || x.Id.ToString().ToUpper().Contains(txtFiltro.Text))
            ).ToList();
            grdBuscador.DataSource = listaPuertos;
        }

        private void cargarClientes()
        {
            var listaClientes = Utiles.context.Clientes.Where(x => x.Estado == "A" && (x.Cedula.ToUpper().Contains(txtFiltro.Text)
               || x.Nombres.ToUpper().Contains(txtFiltro.Text) || x.Apellidos.ToString().ToUpper().Contains(txtFiltro.Text))
           ).ToList();
            grdBuscador.DataSource = listaClientes;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            //textchanged = Cada que se ingresa un valor en la caja de texto
            cargarGrid();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            grabarSeleccion();
        }

        private void grabarSeleccion()
        {
            if (grdBuscador.Rows.Count > 0)
            {
                respuesta1 = grdBuscador.CurrentRow.Cells[0].Value.ToString();

                if (tipo == "C")
                {
                    respuesta2 = grdBuscador.CurrentRow.Cells[2].Value.ToString() + " " + grdBuscador.CurrentRow.Cells[3].Value.ToString();
                }
                else if (tipo == "P")
                {
                    respuesta2 = grdBuscador.CurrentRow.Cells[1].Value.ToString() + " " + grdBuscador.CurrentRow.Cells[2].Value.ToString();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("No existen los registros seleccionados");
            }
        }

        private void grdBuscador_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grabarSeleccion();
        }

        private void grdBuscador_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grabarSeleccion();
        }
    }
}
