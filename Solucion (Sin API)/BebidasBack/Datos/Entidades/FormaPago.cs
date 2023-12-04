using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BebidasBack.Datos.Entidades
{
    public class FormaPago
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public FormaPago(int id, string tipo)
        {
            Id = id;
            Tipo = tipo;
        }
        public FormaPago()
        {

        }
        public override string ToString()
        {
            return Tipo;
        }
    }
}
