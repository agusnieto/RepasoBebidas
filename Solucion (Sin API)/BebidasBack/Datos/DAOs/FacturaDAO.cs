using BebidasBack.Datos.DTOs;
using BebidasBack.Datos.Entidades;
using BebidasBack.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BebidasBack.Datos.DAOs
{
    public class FacturaDAO : IFacturaDAO
    {
        public List<FormaPago> GetFormaPagos()
        {
            FormaPago pago;
            List<FormaPago> lista = new List<FormaPago>();
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_FORMA_PAGO", new List<Parametro>());

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    pago = new FormaPago()
                    {
                        Id = Convert.ToInt32(row.ItemArray[0]),
                        Tipo = row.ItemArray[1].ToString()
                    };
                    lista.Add(pago);
                }
            }
            return lista;
        }

        public bool PostFactura(FacturaDTO factura)
        {
            bool resultado = false;
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("@SOCIO", factura.Socio),
                new Parametro("@EMPLEADO", factura.Empleado),
                new Parametro("@PAGO", factura.Pago)
            };
            int nro_factura = HelperDB.ObtenerInstancia().InsertarSql("SP_POST_FACTURA", parametros, "@FACTURA");

            if (nro_factura > 0)
            {
                int aux = 0;

                factura.Numero = nro_factura;

                if (factura.DetalleFactura != null)
                {
                    foreach (DetalleDTO detalle in factura.DetalleFactura)
                    {
                            List<Parametro> lstDet = new List<Parametro>()
                            {
                                new Parametro("@FACTURA", factura.Numero),
                                new Parametro("@BEBIDA", detalle.Bebida),
                                new Parametro("@CANTIDAD", detalle.Cantidad),
                                new Parametro("@PRECIO", detalle.Precio)
                            };

                        aux += HelperDB.ObtenerInstancia().InsertarSql("SP_POST_DETALLE", lstDet, "");
                    }
                }

                if (aux == factura.DetalleFactura.Count)
                {
                    resultado = true;
                }
            }
            return resultado;
        }
    }
}
