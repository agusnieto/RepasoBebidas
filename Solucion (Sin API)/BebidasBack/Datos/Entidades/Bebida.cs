using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BebidasBack.Datos.Entidades
{
    public class Bebida
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public Bebida(int id, string nombre, double precio)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
        }
        public Bebida()
        {

        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
