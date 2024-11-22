using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_Binario_de_Busqueda_2
{
    internal class Nodo
    {
        public double sueldo {  get; set; }
        public Nodo izq { get; set; }
        public Nodo der {  get; set; }
        public Nodo (double suel)
        {
            sueldo = suel;
            izq = null;
            der = null;
        }
    }
}
