namespace ComercioExterior
{
    partial class frmMantenimientoClientes
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
            grdMantenimientoClientes = new Panel();
            txtApellidos = new TextBox();
            label5 = new Label();
            txtNombres = new TextBox();
            txtCedula = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtID = new TextBox();
            panel2 = new Panel();
            btnGrabar = new Button();
            btnCancelar = new Button();
            grdMantenimientoClientes.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // grdMantenimientoClientes
            // 
            grdMantenimientoClientes.Controls.Add(txtApellidos);
            grdMantenimientoClientes.Controls.Add(label5);
            grdMantenimientoClientes.Controls.Add(txtNombres);
            grdMantenimientoClientes.Controls.Add(txtCedula);
            grdMantenimientoClientes.Controls.Add(label4);
            grdMantenimientoClientes.Controls.Add(label3);
            grdMantenimientoClientes.Controls.Add(label2);
            grdMantenimientoClientes.Controls.Add(label1);
            grdMantenimientoClientes.Controls.Add(txtID);
            grdMantenimientoClientes.Dock = DockStyle.Top;
            grdMantenimientoClientes.Location = new Point(0, 0);
            grdMantenimientoClientes.Name = "grdMantenimientoClientes";
            grdMantenimientoClientes.Size = new Size(431, 263);
            grdMantenimientoClientes.TabIndex = 0;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(184, 203);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(128, 23);
            txtApellidos.TabIndex = 8;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(56, 203);
            label5.Name = "label5";
            label5.Size = new Size(91, 24);
            label5.TabIndex = 7;
            label5.Text = "Apellidos:";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(184, 158);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(128, 23);
            txtNombres.TabIndex = 6;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(184, 113);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(128, 23);
            txtCedula.TabIndex = 5;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(77, 112);
            label4.Name = "label4";
            label4.Size = new Size(70, 24);
            label4.TabIndex = 4;
            label4.Text = "Cédula:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 157);
            label3.Name = "label3";
            label3.Size = new Size(91, 24);
            label3.TabIndex = 3;
            label3.Text = "Nombres:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(114, 66);
            label2.Name = "label2";
            label2.Size = new Size(33, 24);
            label2.TabIndex = 2;
            label2.Text = "ID:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(108, 21);
            label1.Name = "label1";
            label1.Size = new Size(242, 28);
            label1.TabIndex = 1;
            label1.Text = "Mantenimiento de los Clientes";
            label1.Click += label1_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(184, 66);
            txtID.Name = "txtID";
            txtID.Size = new Size(128, 23);
            txtID.TabIndex = 0;
            txtID.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnGrabar);
            panel2.Controls.Add(btnCancelar);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 263);
            panel2.Name = "panel2";
            panel2.Size = new Size(431, 41);
            panel2.TabIndex = 1;
            // 
            // btnGrabar
            // 
            btnGrabar.Dock = DockStyle.Right;
            btnGrabar.Location = new Point(241, 0);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(91, 41);
            btnGrabar.TabIndex = 1;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Dock = DockStyle.Right;
            btnCancelar.Location = new Point(332, 0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 41);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmMantenimientoClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 304);
            Controls.Add(panel2);
            Controls.Add(grdMantenimientoClientes);
            Name = "frmMantenimientoClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento Clientes";
            Load += frmMantenimientoClientes_Load;
            grdMantenimientoClientes.ResumeLayout(false);
            grdMantenimientoClientes.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel grdMantenimientoClientes;
        private Panel panel2;
        private Button btnGrabar;
        private Button btnCancelar;
        private Label label2;
        private Label label1;
        private TextBox txtID;
        private Label label4;
        private Label label3;
        private TextBox txtNombres;
        private TextBox txtCedula;
        private TextBox txtApellidos;
        private Label label5;
    }
}