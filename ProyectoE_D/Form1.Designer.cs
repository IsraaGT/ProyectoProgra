namespace ProyectoE_D
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblProducto = new Label();
            txtProducto = new TextBox();
            lblCosto = new Label();
            txtCosto = new TextBox();
            lblCantidad = new Label();
            nudCantidad = new NumericUpDown();
            btnRegistrar = new Button();
            btnAbrirGestion = new Button();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFecha.ForeColor = Color.FromArgb(0, 102, 204);
            lblFecha.Location = new Point(104, 95);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(60, 23);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(198, 95);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(296, 27);
            dtpFecha.TabIndex = 1;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProducto.ForeColor = Color.FromArgb(0, 102, 204);
            lblProducto.Location = new Point(104, 135);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(88, 23);
            lblProducto.TabIndex = 2;
            lblProducto.Text = "Producto:";
            // 
            // txtProducto
            // 
            txtProducto.Font = new Font("Segoe UI", 10F);
            txtProducto.Location = new Point(198, 135);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(296, 30);
            txtProducto.TabIndex = 3;
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCosto.ForeColor = Color.FromArgb(0, 102, 204);
            lblCosto.Location = new Point(104, 175);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(60, 23);
            lblCosto.TabIndex = 4;
            lblCosto.Text = "Costo:";
            // 
            // txtCosto
            // 
            txtCosto.Font = new Font("Segoe UI", 10F);
            txtCosto.Location = new Point(198, 175);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(296, 30);
            txtCosto.TabIndex = 5;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantidad.ForeColor = Color.FromArgb(0, 102, 204);
            lblCantidad.Location = new Point(104, 215);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(88, 23);
            lblCantidad.TabIndex = 6;
            lblCantidad.Text = "Cantidad:";
            // 
            // nudCantidad
            // 
            nudCantidad.Font = new Font("Segoe UI", 10F);
            nudCantidad.Location = new Point(198, 215);
            nudCantidad.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(296, 30);
            nudCantidad.TabIndex = 7;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(135, 206, 250);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegistrar.ForeColor = Color.Black;
            btnRegistrar.Location = new Point(126, 276);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(161, 82);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar Venta";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrarVenta_Click;
            // 
            // btnAbrirGestion
            // 
            btnAbrirGestion.BackColor = Color.FromArgb(0, 204, 102);
            btnAbrirGestion.FlatStyle = FlatStyle.Flat;
            btnAbrirGestion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAbrirGestion.ForeColor = Color.White;
            btnAbrirGestion.Location = new Point(341, 276);
            btnAbrirGestion.Name = "btnAbrirGestion";
            btnAbrirGestion.Size = new Size(153, 82);
            btnAbrirGestion.TabIndex = 9;
            btnAbrirGestion.Text = "Ver Ventas";
            btnAbrirGestion.UseVisualStyleBackColor = false;
            btnAbrirGestion.Click += btnAbrirGestion_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(0, 51, 102);
            lblTitulo.Location = new Point(208, 34);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(264, 32);
            lblTitulo.TabIndex = 10;
            lblTitulo.Text = "REGISTRO DE VENTAS";
            // 
            // Form1
            // 
            ClientSize = new Size(607, 407);
            Controls.Add(lblTitulo);
            Controls.Add(btnAbrirGestion);
            Controls.Add(btnRegistrar);
            Controls.Add(nudCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(txtCosto);
            Controls.Add(lblCosto);
            Controls.Add(txtProducto);
            Controls.Add(lblProducto);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Name = "Form1";
            Text = "Ingreso de Ventas";
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnAbrirGestion;
        private Label lblTitulo;
    }
}
