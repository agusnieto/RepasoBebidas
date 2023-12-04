using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BebidasBack.Datos.Entidades
{
    public class DetalleFactura
    {
        public int Id { get; set; }
        public Bebida Bebida { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public DetalleFactura(int id, Factura factura, Bebida bebida, int cantidad, double precio)
        {
            Id = id;
            Bebida = bebida;
            Cantidad = cantidad;
            Precio = precio;
        }
        public DetalleFactura()
        {

        }
    }
}
