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
        public int IdPuerto = 0;

        public frmMantenimientoPuerto()
        {
            InitializeComponent(); 
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
            if (IdPuerto == 0)
            {
                Puerto objpuerto = new Puerto();
                objpuerto.Descripcion = txtDescripcion.Text;
                objpuerto.Codigo = txtCodigo.Text;
                objpuerto.Estado = "A";

                Utiles.context.Puertos.Add(objpuerto);
                Utiles.context.SaveChanges();

                txtID.Text = objpuerto.Id.ToString();
                MessageBox.Show($"Puerto {objpuerto.Id} creado con éxito");
                this.Close();
            }
            else
            {
                var objPuerto = Utiles.context.Puertos.Find(IdPuerto);
                objPuerto.Codigo = txtCodigo.Text;
                objPuerto.Descripcion = txtDescripcion.Text;
                Utiles.context.Puertos.Update(objPuerto);
                Utiles.context.SaveChanges(true);
                MessageBox.Show($"Puerto {objPuerto.Id} actualizado con éxito");
            }
            this.Close();
        }

        private void frmMantenimientoPuerto_Load(object sender, EventArgs e)
        {
            if (IdPuerto != 0)
            {
                var objPuerto = Utiles.context.Puertos.Find(IdPuerto);
                if (objPuerto != null)
                {
                    txtID.Text= objPuerto.Id.ToString();
                    txtCodigo.Text = objPuerto.Codigo;
                    txtDescripcion.Text = objPuerto.Descripcion;
                }
                else
                {
                    MessageBox.Show($"No existen registros {txtID}");
                    this.Close();
                }
            }
        }
    }
}
/*
vamos a crear el boton eliminar, cambia el estado, pero al eliminar le sale un mensaje de ocnfirmacion si desea eliminar
pantalla identica para el cliente 
 */