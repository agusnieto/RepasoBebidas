using BebidasBack.Datos.DAOs;
using BebidasBack.Datos.DTOs;
using BebidasBack.Datos.Entidades;
using BebidasBack.Datos.Interfaces;
using BebidasBack.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BebidasBack.Servicio.Implementacion
{
    public class ServicioDAO : IServicioDAO
    {
        private static ServicioDAO instancia;
        private IBebidaDAO bebidaDAO;
        private IEmpleadoDAO empleadoDAO;
        private ISocioDAO socioDAO;
        private IFacturaDAO facturaDAO;

        private ServicioDAO()
        {
            bebidaDAO = new BebidaDAO();
            empleadoDAO = new EmpleadoDAO();
            socioDAO = new SocioDAO();
            facturaDAO = new FacturaDAO();
        }
        public static ServicioDAO ObtenerServicio()
        {
            if (instancia == null)
            {
                instancia = new ServicioDAO();
            }
            return instancia;
        }

        //Bebida
        public Bebida GetBebida(int id)
        {
            return bebidaDAO.GetBebida(id);
        }
        //Empleado
        public List<Empleado> GetEmpleados()
        {
            return empleadoDAO.GetEmpleados();
        }
        //Socio
        public List<Socio> GetSocios()
        {
            return socioDAO.GetSocios();
        }
        //Factura
        public List<FormaPago> GetFormaPagos()
        {
            return facturaDAO.GetFormaPagos();
        }
        public bool PostFactura(FacturaDTO factura)
        {
            return facturaDAO.PostFactura(factura);
        }
    }
}
