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
    public partial class frmMantenimientoPuerto : Form
    {
        public Eff2Context contexto;
        public int IdPuerto = 0;

        public frmMantenimientoPuerto()
        {
            InitializeComponent();
            contexto = new Eff2Context();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Puerto objpuerto = new Puerto();
            objpuerto.Descripcion = txtDescripcion.Text;
            objpuerto.Codigo = txtCodigo.Text;
            objpuerto.Estado = "A";



            contexto.Puertos.Add(objpuerto);
            contexto.SaveChanges();

            txtID.Text = objpuerto.Id.ToString();
            MessageBox.Show($"Puerto {objpuerto.Id} creado con éxito");
            this.Close();
        }

        private void frmMantenimientoPuerto_Load(object sender, EventArgs e)
        {

        }
    }
}
