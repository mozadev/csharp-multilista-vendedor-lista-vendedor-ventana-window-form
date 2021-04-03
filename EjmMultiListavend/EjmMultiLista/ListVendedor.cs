using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjmMultiLista
{
    public class ListVendedor
    {
        public Int32 NumElementos { get; set; }
        public Vendedor Inicio { get; set; }
        public Vendedor Fin { get; set; }

        public ListVendedor()
        {
            NumElementos = 0;
            Inicio = null;
            Fin = null;
        }

        public void Add(Vendedor item)
        {
            if (Inicio == null)
            {
                Inicio = item;
                Fin = item;
            }
            else
            {
                Fin.Siguiente = item;
                item.Anterior = Fin;
                Fin = item;
            }
            NumElementos++;
        }

        public void Remove(Vendedor item)
        {
            if (Inicio == item)
            {
                if (Inicio == Fin)
                {
                    Inicio = null;
                    Fin = null;
                }
                else
                {
                    item.Siguiente.Anterior = null;
                    Inicio = item.Siguiente;
                }
            }
            else if (Fin == item)
            {
               item .Anterior .Siguiente  = null;
                Fin = item.Anterior;
            }
            else
            {
                item.Anterior.Siguiente = item.Siguiente;
                item.Siguiente.Anterior = item.Anterior;
            }
            NumElementos--;
        }

        public Vendedor Find(String codigo)
        {
            var vendedor = Inicio;
            while (vendedor != null)
            {
                if (vendedor.Codigo == codigo)
                    return vendedor;
                vendedor = vendedor.Siguiente;
            }

            return null;
        }
    }
}
