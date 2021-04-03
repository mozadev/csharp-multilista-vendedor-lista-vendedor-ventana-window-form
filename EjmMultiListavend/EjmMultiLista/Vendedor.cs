using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjmMultiLista
{
    public class Vendedor
    {
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public Vendedor Siguiente { get; set; }
        public Vendedor Anterior { get; set; }

        public Vendedor()
        {
            Siguiente = null;
            Anterior = null;
        }
    }
}
