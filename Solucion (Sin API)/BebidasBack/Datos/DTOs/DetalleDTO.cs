using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BebidasBack.Datos.DTOs
{
    public class DetalleDTO
    {
        public int Factura { get; set; }
        public int Bebida { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
    }
}
