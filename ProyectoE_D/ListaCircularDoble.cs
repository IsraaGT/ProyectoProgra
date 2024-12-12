using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoE_D
{
    public class ListaVentasCircularDoble
    {
        private NodoVenta _cabeza;

        public void AgregarVenta(Venta nuevaVenta)
        {
            var nuevoNodo = new NodoVenta(nuevaVenta);

            if (_cabeza == null)
            {
                _cabeza = nuevoNodo;
                nuevoNodo.Siguiente = _cabeza;
                nuevoNodo.Anterior = _cabeza;
            }
            else
            {
                var ultimo = _cabeza.Anterior;

                ultimo.Siguiente = nuevoNodo;
                nuevoNodo.Anterior = ultimo;

                nuevoNodo.Siguiente = _cabeza;
                _cabeza.Anterior = nuevoNodo;
            }
        }

        public bool EliminarVenta(string nombreProducto)
        {
            if (_cabeza == null) return false;

            var actual = _cabeza;
            do
            {
                if (actual.Venta.Producto.Equals(nombreProducto, StringComparison.OrdinalIgnoreCase))
                {
                    if (actual == _cabeza && _cabeza.Siguiente == _cabeza)
                    {
                        _cabeza = null;
                    }
                    else
                    {
                        actual.Anterior.Siguiente = actual.Siguiente;
                        actual.Siguiente.Anterior = actual.Anterior;

                        if (actual == _cabeza) _cabeza = actual.Siguiente;
                    }
                    return true;
                }
                actual = actual.Siguiente;
            } while (actual != _cabeza);

            return false;
        }

        public List<Venta> ListarVentas()
        {
            var ventas = new List<Venta>();
            if (_cabeza == null) return ventas;

            var actual = _cabeza;
            do
            {
                ventas.Add(actual.Venta);
                actual = actual.Siguiente;
            } while (actual != _cabeza);

            return ventas;
        }

        public bool ModificarVenta(string nombreProducto, Venta nuevaVenta)
        {
            if (_cabeza == null) return false;

            if (EliminarVenta(nombreProducto))
            {
                AgregarVenta(nuevaVenta);
                return true;
            }

            return false;
        }

        public Venta BuscarVenta(string nombreProducto)
        {
            if (_cabeza == null) return null;

            var actual = _cabeza;
            do
            {
                if (actual.Venta.Producto.Equals(nombreProducto, StringComparison.OrdinalIgnoreCase))
                {
                    return actual.Venta;
                }
                actual = actual.Siguiente;
            } while (actual != _cabeza);

            return null;
        }
    }
}
