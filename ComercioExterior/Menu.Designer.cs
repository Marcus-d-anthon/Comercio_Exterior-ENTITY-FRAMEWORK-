namespace ComercioExterior
{
    partial class Menu
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
            btnManCliente = new Button();
            btnManPuertos = new Button();
            btnTransacciones = new Button();
            SuspendLayout();
            // 
            // btnManCliente
            // 
            btnManCliente.Location = new Point(66, 55);
            btnManCliente.Name = "btnManCliente";
            btnManCliente.Size = new Size(159, 31);
            btnManCliente.TabIndex = 0;
            btnManCliente.Text = "Mantenimiento Clientes";
            btnManCliente.UseVisualStyleBackColor = true;
            btnManCliente.Click += btnManCliente_Click;
            // 
            // btnManPuertos
            // 
            btnManPuertos.Location = new Point(249, 55);
            btnManPuertos.Name = "btnManPuertos";
            btnManPuertos.Size = new Size(155, 33);
            btnManPuertos.TabIndex = 1;
            btnManPuertos.Text = "Mantenimiento Puertos";
            btnManPuertos.UseVisualStyleBackColor = true;
            btnManPuertos.Click += btnManPuertos_Click;
            // 
            // btnTransacciones
            // 
            btnTransacciones.Location = new Point(157, 112);
            btnTransacciones.Name = "btnTransacciones";
            btnTransacciones.Size = new Size(155, 33);
            btnTransacciones.TabIndex = 2;
            btnTransacciones.Text = "Transacciones";
            btnTransacciones.UseVisualStyleBackColor = true;
            btnTransacciones.Click += btnTransacciones_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 170);
            Controls.Add(btnTransacciones);
            Controls.Add(btnManPuertos);
            Controls.Add(btnManCliente);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnManCliente;
        private Button btnManPuertos;
        private Button btnTransacciones;
    }
}