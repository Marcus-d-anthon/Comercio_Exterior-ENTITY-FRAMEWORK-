using ComercioExterior.Context;
using ComercioExterior.Modelo;

namespace ComercioExterior
{
    public partial class frmPuertos : Form
    {

        public frmPuertos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPuertos_Load(object sender, EventArgs e)
        {
            var ListaPuerto = Utiles.context.Puertos.ToList();
            grdPuertos.DataSource = ListaPuerto;
        }

        public void CargarGrid()
        {
            var ListarPuertos = Utiles.context.Puertos.ToList();
            grdPuertos.DataSource = ListarPuertos;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmMantenimientoPuerto objFormulario = new frmMantenimientoPuerto();
            objFormulario.ShowDialog();
            var ListaPuerto = Utiles.context.Puertos.ToList();
            grdPuertos.DataSource = ListaPuerto;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void Modificar()
        {
            if (grdPuertos.RowCount <= 0)
            {
                MessageBox.Show("No existen datos");
                return;
            }
            else
            {   //CurrentRow: Se obtiene la fila seleccionada
                //Value = object Convert.ToInt32 = integer
                int id = Convert.ToInt32(grdPuertos.CurrentRow.Cells[0].Value);
                frmMantenimientoPuerto objFormulario = new frmMantenimientoPuerto();

                objFormulario.IdPuerto = id;
                objFormulario.ShowDialog();
                CargarGrid();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdPuertos.RowCount <= 0)
            {
                MessageBox.Show("No existen datos");
                return;
            }
            else
            {
                int id = Convert.ToInt32(grdPuertos.CurrentRow.Cells[0].Value);
                Puerto objPuerto = new Puerto();
                objPuerto.Estado = "I";

            }
        }
    }
}
