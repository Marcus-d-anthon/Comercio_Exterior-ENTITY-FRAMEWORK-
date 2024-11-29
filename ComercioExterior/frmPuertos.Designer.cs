namespace ComercioExterior
{
    partial class frmPuertos
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
            grdPuertos = new DataGridView();
            btnSalir = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnNuevo = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdPuertos).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(grdPuertos);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(564, 206);
            panel2.TabIndex = 1;
            // 
            // grdPuertos
            // 
            grdPuertos.AllowUserToAddRows = false;
            grdPuertos.AllowUserToDeleteRows = false;
            grdPuertos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdPuertos.Dock = DockStyle.Fill;
            grdPuertos.Location = new Point(0, 0);
            grdPuertos.Name = "grdPuertos";
            grdPuertos.ReadOnly = true;
            grdPuertos.Size = new Size(564, 206);
            grdPuertos.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Right;
            btnSalir.Location = new Point(489, 206);
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
            btnEliminar.Location = new Point(414, 206);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 49);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Dock = DockStyle.Right;
            btnModificar.Location = new Point(339, 206);
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
            btnNuevo.Location = new Point(264, 206);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 49);
            btnNuevo.TabIndex = 5;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // frmPuertos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 255);
            Controls.Add(btnNuevo);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnSalir);
            Controls.Add(panel2);
            Name = "frmPuertos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formularios Puertos";
            Load += frmPuertos_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdPuertos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView grdPuertos;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnNuevo;
    }
}
