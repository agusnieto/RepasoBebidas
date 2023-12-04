using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BebidasBack.Datos.DTOs
{
    public class FacturaDTO
    {
        public int Numero { get; set; }
        public int Socio { get; set; }
        public int Empleado { get; set; }
        public int Pago { get; set; }
        public List<DetalleDTO> DetalleFactura { get; set; }
    }
}
