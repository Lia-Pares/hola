using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_Binario_de_Busqueda_3
{
    internal class Nodo
    {
        public byte numero {  get; set; }
        public Nodo izq {  get; set; }
        public Nodo der {  get; set; }
        public Nodo (byte num)
        {
            numero = num;
            izq = null;
            der = null;
        }
    }
}
