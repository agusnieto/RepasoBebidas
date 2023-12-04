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
    public class BebidaDAO : IBebidaDAO
    {
        public Bebida GetBebida(int id)
        {
            Bebida bebida = null;
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("@ID", id)
            };

            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_BEBIDA", parametros);

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    bebida = new Bebida()
                    {
                        Id = Convert.ToInt32(row.ItemArray[0]),
                        Nombre = row.ItemArray[1].ToString(),
                        Precio = Convert.ToDouble(row.ItemArray[2].ToString())
                    };
                }
            }
            return bebida;
        }
    }
}
