using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_Binario_de_Busqueda
{
    class Nodo
    {
        public int numero { get; set; }
        public Nodo izq { get; set; }
        public Nodo der { get; set; }
        public Nodo(int num)
        {
            numero = num;
            izq = null;
            der = null;
        }
    }
}
