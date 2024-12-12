using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoE_D
{
    public class NodoVenta
    {
        public Venta Venta { get; set; }
        public NodoVenta Siguiente { get; set; }
        public NodoVenta Anterior { get; set; }

        public NodoVenta(Venta venta)
        {
            Venta = venta;
            Siguiente = this; 
            Anterior = this; 
        }

    }
}
