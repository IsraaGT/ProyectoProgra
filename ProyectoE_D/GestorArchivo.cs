using System;
using System.Collections.Generic;
using System.IO;

namespace ProyectoE_D
{
    public static class GestorArchivo
    {
        private const string RutaArchivo = "registro.txt";

        public static void GuardarVentas(List<Venta> ventas)
        {
            using (var escritor = new StreamWriter(RutaArchivo))
            {
                foreach (var venta in ventas)
                {
                    escritor.WriteLine($"{venta.Fecha}|{venta.Producto}|{venta.Costo}|{venta.Cantidad}");
                }
            }
        }

        public static List<Venta> CargarVentas()
        {
            var ventas = new List<Venta>();

            if (File.Exists(RutaArchivo))
            {
                using (var lector = new StreamReader(RutaArchivo))
                {
                    string linea;
                    while ((linea = lector.ReadLine()) != null)
                    {
                        var partes = linea.Split('|');
                        var fecha = DateTime.Parse(partes[0]);
                        var producto = partes[1];
                        var costo = decimal.Parse(partes[2]);  // Asegúrate de usar decimal
                        var cantidad = int.Parse(partes[3]);

                        ventas.Add(new Venta(fecha, producto, costo, cantidad));
                    }
                }
            }

            return ventas;
        }
    }
}
