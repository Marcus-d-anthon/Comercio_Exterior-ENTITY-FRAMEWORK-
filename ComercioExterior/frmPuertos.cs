using ComercioExterior.Context;

namespace ComercioExterior
{
    public partial class frmPuertos : Form
    {
        public Eff2Context contexto;
        public frmPuertos()
        {
            InitializeComponent();
            contexto = new Eff2Context();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPuertos_Load(object sender, EventArgs e)
        {
            var ListaPuerto = contexto.Puertos.ToList();
            grdPuertos.DataSource = ListaPuerto;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmMantenimientoPuerto objFormulario = new frmMantenimientoPuerto();
            objFormulario.ShowDialog();
            var ListaPuerto = contexto.Puertos.ToList();
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
            }
        }
    }
}
