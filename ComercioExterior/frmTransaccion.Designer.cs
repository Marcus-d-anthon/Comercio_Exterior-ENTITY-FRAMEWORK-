namespace ComercioExterior
{
    partial class frmTransaccion
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
            txtDescripcionPuerto = new TextBox();
            txtPuerto = new TextBox();
            txtCliente = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            txtNombreCliente = new TextBox();
            label5 = new Label();
            cmbTTransaccion = new ComboBox();
            txtCosto = new TextBox();
            label6 = new Label();
            txtComentario = new TextBox();
            label7 = new Label();
            btnGrabar = new Button();
            SuspendLayout();
            // 
            // txtDescripcionPuerto
            // 
            txtDescripcionPuerto.Location = new Point(378, 157);
            txtDescripcionPuerto.Name = "txtDescripcionPuerto";
            txtDescripcionPuerto.ReadOnly = true;
            txtDescripcionPuerto.Size = new Size(253, 23);
            txtDescripcionPuerto.TabIndex = 16;
            // 
            // txtPuerto
            // 
            txtPuerto.Location = new Point(209, 157);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(128, 23);
            txtPuerto.TabIndex = 14;
            txtPuerto.KeyDown += txtPuerto_KeyDown;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(209, 112);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(128, 23);
            txtCliente.TabIndex = 13;
            txtCliente.KeyDown += txtCliente_KeyDown;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(102, 112);
            label4.Name = "label4";
            label4.Size = new Size(70, 24);
            label4.TabIndex = 12;
            label4.Text = "Cliente:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(81, 156);
            label3.Name = "label3";
            label3.Size = new Size(91, 24);
            label3.TabIndex = 11;
            label3.Text = "Puerto:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(139, 71);
            label2.Name = "label2";
            label2.Size = new Size(33, 24);
            label2.TabIndex = 10;
            label2.Text = "ID:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtID
            // 
            txtID.Location = new Point(209, 71);
            txtID.Name = "txtID";
            txtID.Size = new Size(56, 23);
            txtID.TabIndex = 9;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, 22);
            label1.Name = "label1";
            label1.Size = new Size(207, 28);
            label1.TabIndex = 17;
            label1.Text = "Ingrese su Transaccion";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(378, 112);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.ReadOnly = true;
            txtNombreCliente.Size = new Size(253, 23);
            txtNombreCliente.TabIndex = 18;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ImageAlign = ContentAlignment.MiddleRight;
            label5.Location = new Point(-12, 198);
            label5.Name = "label5";
            label5.Size = new Size(184, 24);
            label5.TabIndex = 19;
            label5.Text = "Tipo de Transacción:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbTTransaccion
            // 
            cmbTTransaccion.FormattingEnabled = true;
            cmbTTransaccion.Location = new Point(209, 201);
            cmbTTransaccion.Name = "cmbTTransaccion";
            cmbTTransaccion.Size = new Size(128, 23);
            cmbTTransaccion.TabIndex = 20;
            cmbTTransaccion.Click += cmbTTransaccion_Click;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(209, 242);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(128, 23);
            txtCosto.TabIndex = 22;
            txtCosto.TextChanged += txtCosto_TextChanged;
            txtCosto.KeyPress += txtCosto_KeyPress;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(81, 242);
            label6.Name = "label6";
            label6.Size = new Size(91, 24);
            label6.TabIndex = 21;
            label6.Text = "Costo:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(209, 285);
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(289, 23);
            txtComentario.TabIndex = 24;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ImageAlign = ContentAlignment.MiddleRight;
            label7.Location = new Point(81, 285);
            label7.Name = "label7";
            label7.Size = new Size(91, 24);
            label7.TabIndex = 23;
            label7.Text = "Comentario:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(520, 337);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(97, 31);
            btnGrabar.TabIndex = 25;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // frmTransaccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 393);
            Controls.Add(btnGrabar);
            Controls.Add(txtComentario);
            Controls.Add(label7);
            Controls.Add(txtCosto);
            Controls.Add(label6);
            Controls.Add(cmbTTransaccion);
            Controls.Add(label5);
            Controls.Add(txtNombreCliente);
            Controls.Add(label1);
            Controls.Add(txtDescripcionPuerto);
            Controls.Add(txtPuerto);
            Controls.Add(txtCliente);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtID);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTransaccion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transaccion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescripcionPuerto;
        private TextBox txtPuerto;
        private TextBox txtCliente;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private TextBox txtNombreCliente;
        private Label label5;
        private ComboBox cmbTTransaccion;
        private TextBox txtCosto;
        private Label label6;
        private TextBox txtComentario;
        private Label label7;
        private Button btnGrabar;
    }
}