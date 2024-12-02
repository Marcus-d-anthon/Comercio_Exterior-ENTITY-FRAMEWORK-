using ComercioExterior.Context;
using ComercioExterior.Modelo;

namespace ComercioExterior
{
    public partial class frmClientes : Form
    {

        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void CargarGrid()
        {
            var ListarClientes = Utiles.context.Clientes.ToList();
            grdClientes.DataSource = ListarClientes;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmMantenimientoClientes objFormulario = new frmMantenimientoClientes();
            objFormulario.ShowDialog();
            var ListaClientes = Utiles.context.Clientes.ToList();
            grdClientes.DataSource = ListaClientes;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void Modificar()
        {
            if (grdClientes.RowCount <= 0)
            {
                MessageBox.Show("No existen datos");
                return;
            }
            else
            {   //CurrentRow: Se obtiene la fila seleccionada
                //Value = object Convert.ToInt32 = integer
                int id = Convert.ToInt32(grdClientes.CurrentRow.Cells[0].Value);
                frmMantenimientoClientes objFormulario = new frmMantenimientoClientes();

                objFormulario.IdClientes = id;
                objFormulario.ShowDialog();
                CargarGrid();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdClientes.RowCount <= 0)
            {
                MessageBox.Show("No existen datos");
                return;
            }
            else
            {
                int id = Convert.ToInt32(grdClientes.CurrentRow.Cells[0].Value);
                Puerto objClientes = new Puerto();
                objClientes.Estado = "I";

            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            var ListaClientes = Utiles.context.Clientes.ToList();
            grdClientes .DataSource = ListaClientes;
        }
    }
}
