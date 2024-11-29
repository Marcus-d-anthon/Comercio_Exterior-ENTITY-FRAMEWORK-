namespace ComercioExterior
{
    partial class frmMantenimientoPuerto
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
            panel1 = new Panel();
            txtDescripcion = new TextBox();
            txtCodigo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtID = new TextBox();
            panel2 = new Panel();
            btnGrabar = new Button();
            btnCancelar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(txtCodigo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtID);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 249);
            panel1.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(184, 158);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(128, 23);
            txtDescripcion.TabIndex = 6;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(184, 113);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(128, 23);
            txtCodigo.TabIndex = 5;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(77, 112);
            label4.Name = "label4";
            label4.Size = new Size(70, 24);
            label4.TabIndex = 4;
            label4.Text = "Código:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 157);
            label3.Name = "label3";
            label3.Size = new Size(91, 24);
            label3.TabIndex = 3;
            label3.Text = "Descripción:";
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
            label1.Text = "Mantenimiento de los Puertos";
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
            panel2.Location = new Point(0, 249);
            panel2.Name = "panel2";
            panel2.Size = new Size(431, 39);
            panel2.TabIndex = 1;
            // 
            // btnGrabar
            // 
            btnGrabar.Dock = DockStyle.Right;
            btnGrabar.Location = new Point(241, 0);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(91, 39);
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
            btnCancelar.Size = new Size(99, 39);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmMantenimientoPuerto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 288);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmMantenimientoPuerto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMantenimientoPuerto";
            Load += frmMantenimientoPuerto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnGrabar;
        private Button btnCancelar;
        private Label label2;
        private Label label1;
        private TextBox txtID;
        private Label label4;
        private Label label3;
        private TextBox txtDescripcion;
        private TextBox txtCodigo;
    }
}