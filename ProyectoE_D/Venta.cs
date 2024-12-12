using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoE_D
{
    public class Venta
    {
        public DateTime Fecha { get; set; }
        public string Producto { get; set; }
        public decimal Costo { get; set; }
        public int Cantidad { get; set; }
        public decimal Total => Costo * Cantidad; 

        public Venta(DateTime fecha, string producto, decimal costo, int cantidad)
        {
            Fecha = fecha;
            Producto = producto;
            Costo = costo;
            Cantidad = cantidad;
        }

        public override string ToString()
        {
            return $"{Fecha:dd/MM/yyyy} - {Producto}: {Cantidad} x {Costo:C} = {Total:C}";
        }
    }
}
