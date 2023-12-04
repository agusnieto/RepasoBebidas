using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BebidasBack.Datos.Entidades
{
    public class Factura
    {
        public int Numero { get; set; }
        public Socio Socio { get; set; }
        public Empleado Empleado { get; set; }
        public FormaPago Pago { get; set; }
        public DateTime Fecha { get; set; }
        public List<DetalleFactura> DetalleFactura { get; set; }
        public Factura(int numero, Socio socio, Empleado empleado, FormaPago pago, DateTime fecha, List<DetalleFactura> detalleFactura)
        {
            Numero = numero;
            Socio = socio;
            Empleado = empleado;
            Pago = pago;
            Fecha = fecha;
            DetalleFactura = detalleFactura;
        }
        public Factura()
        {

        }
        public double Total()
        {
            double total = 0;
            foreach (DetalleFactura detalle in DetalleFactura)
            {
                total += detalle.Precio * detalle.Cantidad;
            }
            return total;
        }
        public void QuitarDetalleFactura(int id)
        {
            DetalleFactura.RemoveAt(id);
        }
    }
}
