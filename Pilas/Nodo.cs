using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas
{
    internal class Nodo
    {
        private string valor;
        private string infija;
        private string prefija;
        private string posfija;
        private Nodo sgte;

        public string Valor { get => valor; set => valor = value; }
        public string Infija { get => infija; set => infija = value; }
        public string Prefija { get => prefija; set => prefija = value; }
        public string Posfija { get => posfija; set => posfija = value; }
        internal Nodo Sgte { get => sgte; set => sgte = value; }
    }
}
