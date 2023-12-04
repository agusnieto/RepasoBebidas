using BebidasBack.Datos.DTOs;
using BebidasBack.Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BebidasBack.Datos.Interfaces
{
    public interface IFacturaDAO
    {
        List<FormaPago> GetFormaPagos();
        bool PostFactura(FacturaDTO factura);

    }
}
