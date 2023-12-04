using BebidasBack.Datos.DTOs;
using BebidasBack.Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BebidasBack.Servicio.Interfaz
{
    public interface IServicioDAO
    {
        //Bebida
        Bebida GetBebida(int id);
        //Empleado
        List<Empleado> GetEmpleados();
        //Socio
        List<Socio> GetSocios();
        //Factura
        List<FormaPago> GetFormaPagos();
        bool PostFactura(FacturaDTO factura);

    }
}
