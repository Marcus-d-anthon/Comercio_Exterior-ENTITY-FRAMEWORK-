namespace ComercioExterior
{
    partial class frmBuscador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            txtFiltro = new TextBox();
            panel1 = new Panel();
            grdBuscador = new DataGridView();
            panel3 = new Panel();
            btnSeleccionar = new Button();
            btnSalir = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdBuscador).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(txtFiltro);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(636, 24);
            panel2.TabIndex = 1;
            // 
            // txtFiltro
            // 
            txtFiltro.Dock = DockStyle.Fill;
            txtFiltro.Location = new Point(0, 0);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(636, 23);
            txtFiltro.TabIndex = 0;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(grdBuscador);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(636, 184);
            panel1.TabIndex = 2;
            // 
            // grdBuscador
            // 
            grdBuscador.AllowUserToAddRows = false;
            grdBuscador.AllowUserToDeleteRows = false;
            grdBuscador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdBuscador.Dock = DockStyle.Fill;
            grdBuscador.Location = new Point(0, 0);
            grdBuscador.Name = "grdBuscador";
            grdBuscador.ReadOnly = true;
            grdBuscador.Size = new Size(636, 184);
            grdBuscador.TabIndex = 0;
            grdBuscador.CellContentDoubleClick += grdBuscador_CellContentDoubleClick;
            grdBuscador.CellDoubleClick += grdBuscador_CellDoubleClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSeleccionar);
            panel3.Controls.Add(btnSalir);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 208);
            panel3.Name = "panel3";
            panel3.Size = new Size(636, 43);
            panel3.TabIndex = 3;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Dock = DockStyle.Right;
            btnSeleccionar.Location = new Point(435, 0);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(101, 43);
            btnSeleccionar.TabIndex = 1;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Right;
            btnSalir.Location = new Point(536, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 43);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmBuscador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 251);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "frmBuscador";
            Text = "Buscador";
            Load += frmBuscador_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdBuscador).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel1;
        private DataGridView grdBuscador;
        private Panel panel3;
        private TextBox txtFiltro;
        private Button btnSalir;
        private Button btnSeleccionar;
    }
}