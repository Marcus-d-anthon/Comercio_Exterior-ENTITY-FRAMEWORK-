namespace ComercioExterior
{
    partial class frmClientes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            grdClientes = new DataGridView();
            btnSalir = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnNuevo = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdClientes).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(grdClientes);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(611, 206);
            panel2.TabIndex = 1;
            // 
            // grdClientes
            // 
            grdClientes.AllowUserToAddRows = false;
            grdClientes.AllowUserToDeleteRows = false;
            grdClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdClientes.Dock = DockStyle.Fill;
            grdClientes.Location = new Point(0, 0);
            grdClientes.Name = "grdClientes";
            grdClientes.ReadOnly = true;
            grdClientes.Size = new Size(611, 206);
            grdClientes.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Right;
            btnSalir.Location = new Point(536, 206);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 49);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Dock = DockStyle.Right;
            btnEliminar.Location = new Point(461, 206);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 49);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Dock = DockStyle.Right;
            btnModificar.Location = new Point(386, 206);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 49);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Dock = DockStyle.Right;
            btnNuevo.Location = new Point(311, 206);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 49);
            btnNuevo.TabIndex = 5;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 255);
            Controls.Add(btnNuevo);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnSalir);
            Controls.Add(panel2);
            Name = "frmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formularios Clientes";
            Load += frmClientes_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView grdClientes;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnNuevo;
    }
}
