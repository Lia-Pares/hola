using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas
{
    internal class Lista
    {
        private Nodo primero = null;
        private Nodo ultimo = null;
        public void Insertar(string infi, string pre, string pos)
        {
            Nodo nuevo = new Nodo();
            nuevo.Infija = infi;
            nuevo.Prefija = pre;
            nuevo.Posfija = pos;
            if (primero == null)
            {
                primero = nuevo;
                primero.Sgte = null;;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Sgte = nuevo;
                nuevo.Sgte = null;
                ultimo = nuevo;
            }
        }
        public void Mostrar(ListView li)
        {
            Nodo actual = primero;
            while (actual != null)
            {
                ListViewItem cabe = new ListViewItem(actual.Infija.ToString());
                cabe.SubItems.Add(actual.Prefija);
                cabe.SubItems.Add(actual.Posfija);
                li.Items.Add(cabe);
                actual = actual.Sgte;
            }
        }
    }
}
