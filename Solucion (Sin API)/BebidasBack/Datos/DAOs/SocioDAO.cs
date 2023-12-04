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
    public class SocioDAO : ISocioDAO
    {
        public List<Socio> GetSocios()
        {
            Socio socio;
            List<Socio> lista = new List<Socio>();
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_SOCIOS", new List<Parametro>());

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    socio = new Socio()
                    {
                        Id = Convert.ToInt32(row.ItemArray[0]),
                        Nombre = row.ItemArray[1].ToString(),
                        Apellido = row.ItemArray[2].ToString()
                    };
                    lista.Add(socio);
                }
            }
            return lista;
        }
    }
}
