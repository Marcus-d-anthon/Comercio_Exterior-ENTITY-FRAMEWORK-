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
    public partial class frmMantenimientoClientes : Form
    {
        public int IdClientes = 0;

        public frmMantenimientoClientes()
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
            if (IdClientes == 0)
            {
                Cliente objCliente = new Cliente();
                objCliente.Cedula = txtCedula.Text;
                objCliente.Nombres = txtNombres.Text;
                objCliente.Apellidos = txtApellidos.Text;
                objCliente.Estado = "A";

                Utiles.context.Clientes.Add(objCliente);
                Utiles.context.SaveChanges();

                txtID.Text = objCliente.Id.ToString();
                MessageBox.Show($"Cliente {objCliente.Id} creado con éxito");
                this.Close();
            }
            else
            {
                var objCliente = Utiles.context.Clientes.Find(IdClientes);
                objCliente.Cedula = txtCedula.Text;
                objCliente.Nombres = txtNombres.Text;
                objCliente.Apellidos = txtApellidos.Text;
                Utiles.context.Clientes.Update(objCliente);
                Utiles.context.SaveChanges(true);
                MessageBox.Show($"Cliente {objCliente.Id} actualizado con éxito");
            }
            this.Close();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMantenimientoClientes_Load(object sender, EventArgs e)
        {
            if (IdClientes != 0)
            {
                var objClientes = Utiles.context.Clientes.Find(IdClientes);
                if (objClientes != null)
                {
                    txtID.Text = objClientes.Id.ToString();
                    txtCedula.Text = objClientes.Cedula;
                    txtNombres.Text = objClientes.Nombres;
                    txtApellidos.Text = objClientes.Apellidos;
                }
                else
                {
                    MessageBox.Show($"No existen Clientes {txtID}");
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