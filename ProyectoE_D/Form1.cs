using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoE_D
{
    public partial class Form1 : Form
    {
        private ListaVentasCircularDoble ventasLista = new ListaVentasCircularDoble();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtpFecha.Value;
            string nombreProducto = txtProducto.Text;
            decimal precio;
            int cantidad;

            if (string.IsNullOrEmpty(nombreProducto) || !decimal.TryParse(txtCosto.Text, out precio))
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.");
                return;
            }

            cantidad = (int)nudCantidad.Value;

            Venta nuevaVenta = new Venta(fecha, nombreProducto, precio, cantidad);

            ventasLista.AgregarVenta(nuevaVenta);

            GestorArchivo.GuardarVentas(ventasLista.ListarVentas());

            MessageBox.Show("Venta registrada exitosamente.");
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            dtpFecha.Value = DateTime.Now;
            txtProducto.Clear();
            txtCosto.Clear();
            nudCantidad.Value = 1;
        }

        private void btnAbrirGestion_Click(object sender, EventArgs e)
        {
            Form2 gestionForm = new Form2(ventasLista);
            gestionForm.Show();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
