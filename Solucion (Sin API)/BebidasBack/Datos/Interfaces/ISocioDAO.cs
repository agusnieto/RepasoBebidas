using BebidasBack.Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BebidasBack.Datos.Interfaces
{
    public interface ISocioDAO
    {
        List<Socio> GetSocios();
    }
}
