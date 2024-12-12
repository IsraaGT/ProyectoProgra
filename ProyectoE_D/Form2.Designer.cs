namespace ProyectoE_D
{
    partial class Form2
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
            dgvVentas = new DataGridView();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(12, 31);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.Size = new Size(839, 309);
            dgvVentas.TabIndex = 0;
            dgvVentas.BackgroundColor = Color.FromArgb(240, 240, 240);
            dgvVentas.ForeColor = Color.FromArgb(60, 60, 60);
            dgvVentas.Font = new Font("Arial", 10, FontStyle.Regular);
            dgvVentas.BorderStyle = BorderStyle.None;
            dgvVentas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(50, 358);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(120, 40);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.BackColor = Color.FromArgb(0, 192, 255);
            btnModificar.ForeColor = Color.White;
            btnModificar.Font = new Font("Arial", 10, FontStyle.Bold);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.Click += btnModificarVenta_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(190, 358);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 40);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.BackColor = Color.FromArgb(255, 0, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Font = new Font("Arial", 10, FontStyle.Bold);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.Click += btnEliminarVenta_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(711, 358);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(120, 40);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.BackColor = Color.FromArgb(0, 128, 0);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Font = new Font("Arial", 10, FontStyle.Bold);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Form2
            // 
            ClientSize = new Size(863, 400);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(dgvVentas);
            Name = "Form2";
            Text = "Gestión de Ventas";
            BackColor = Color.FromArgb(255, 255, 255);
            Font = new Font("Arial", 12, FontStyle.Regular);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
    }
}
