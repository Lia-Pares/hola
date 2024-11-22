using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol_Binario_de_Busqueda
{
    class ArbolBB
    {
        public Nodo Insertar(Nodo actual, int num)
        {
            Nodo nuevo = new Nodo(num);
            if( actual == null)
            {
                return nuevo;
            }
            if (num < actual.numero)
            {
                actual.izq = Insertar(actual.izq, num);
            }
            else if (num > actual.numero)
            {
                actual.der = Insertar(actual.der, num);
            }
            else
            {
                MessageBox.Show("No se puede inserta nodos iguales!");
            }
            return actual;
        }
        public void Mostrar(Nodo actual, TreeView tree, TreeNode padre)
        {
            TreeNode cabeRaiz = new TreeNode(actual.numero.ToString());
            if(padre == null)
            {
                tree.Nodes.Add(cabeRaiz);
            }
            else
            {
                padre.Nodes.Add(cabeRaiz);
            }
            if (actual.izq != null) Mostrar(actual.izq, tree, cabeRaiz);
            if (actual.der != null) Mostrar(actual.der, tree, cabeRaiz);
        }
        public Nodo Buscar(Nodo actual, int num)
        {
            while (actual != null)
            {
                if (actual.numero == num)
                {
                    return actual;
                }else if (num < actual.numero)
                {
                    actual = actual.izq;
                }
                else
                {
                    actual = actual.der;
                }
            }
            return null;
        }
        public void PreOrden(Nodo actual, TextBox txt)
        {
            if (actual == null) return;
            txt.Text += actual.numero + " "; //raiz
            PreOrden(actual.izq, txt); // izquierda
            PreOrden(actual.der, txt); // derecha
        }
        public void InOrden(Nodo actual, TextBox txt)
        {
            if (actual == null) return;
            InOrden(actual.izq, txt); // izquierda
            txt.Text += actual.numero + " "; //raiz
            InOrden(actual.der, txt); // derecha
        }
        public void PostOrden(Nodo actual, TextBox txt)
        {
            if (actual == null) return;
            PostOrden(actual.izq, txt); // izquierda
            PostOrden(actual.der, txt); // derecha
            txt.Text += actual.numero + " "; //raiz
        }
    }
}
