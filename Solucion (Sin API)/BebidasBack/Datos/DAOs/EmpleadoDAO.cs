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
    public class EmpleadoDAO : IEmpleadoDAO
    {
        public List<Empleado> GetEmpleados()
        {
            Empleado empleado;
            List<Empleado> lista = new List<Empleado>();
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_EMPLEADOS", new List<Parametro>());

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    empleado = new Empleado()
                    {
                        Legajo = Convert.ToInt32(row.ItemArray[0]),
                        Nombre = row.ItemArray[1].ToString(),
                        Apellido = row.ItemArray[2].ToString()
                    };
                    lista.Add(empleado);
                }
            }
            return lista;
        }
    }
}
