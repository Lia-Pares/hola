using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol_Binario_de_Busqueda_3
{
    internal class ABB_3
    {
        //Nodo raiz = null;
        //int cant = 0;
        public Nodo Insertar(Nodo actual, byte num)
        {
            Nodo nuevo = new Nodo(num);

            if (actual == null) return nuevo;
            else if (num < actual.numero) actual.izq = Insertar(actual.izq, num);
            else if (num > actual.numero) actual.der = Insertar(actual.der, num);
            else 
            { 
                MessageBox.Show("No se puede ingresar nodos iguales"); 
            }
            return actual;
        }
        public void Mostrar(Nodo actual, TreeView tree, TreeNode padre)
        {
            if (actual != null)
            {
                TreeNode cabeRaiz = new TreeNode(actual.numero.ToString());
                if (padre == null) tree.Nodes.Add(cabeRaiz);
                else padre.Nodes.Add(cabeRaiz);
                if (actual.izq != null) Mostrar(actual.izq, tree, cabeRaiz);
                if (actual.der != null) Mostrar(actual.der, tree, cabeRaiz);
            }
        }
        public Nodo Eliminar(Nodo actual, byte num)
        {
            if (actual == null) return null;
            if (num < actual.numero) actual.izq = Insertar(actual.izq, num);
            else if (num > actual.numero) actual.der = Insertar(actual.der, num);
            else
            {
                if (actual.izq == null) return actual.der;
                if (actual.der == null) return actual.izq;
                actual.numero = Minimo(actual.der);
                actual.der = Eliminar(actual.der, actual.numero);
            }
            return actual;
        }
        public byte Minimo(Nodo actual)
        {
            while (actual.izq != null)
            {
                actual = actual.izq;
            }
            return actual.numero;
        }
        public byte maximo(Nodo actual)
        {
            while (actual.der != null)
            {
                actual = actual.der;
            }
            return actual.numero;
        }
        public int Altura(Nodo actual)
        {
            if(actual == null) return 0;
            else
            {
                int altizq = Altura(actual.izq);
                int altder = Altura(actual.der);
                return Math.Max(altizq, altder);
            }
        }
        public Nodo Buscar(Nodo actual, byte num)
        {
            while (actual != null)
            {
                if(num == actual.numero) return actual;
                else if(num < actual.numero) actual = actual.izq;
                else actual = actual.der;
            }
            return null;
        }
        public void PreOrden(Nodo actual, TextBox txt)
        {
            if (actual != null) 
            {
                txt.Text += actual.numero + " ";
                PreOrden(actual.izq, txt);
                PreOrden(actual.der, txt);
            }
        }
        public void InOrden(Nodo actual, TextBox txt)
        {
            if (actual != null)
            {
                InOrden(actual.izq, txt);
                txt.Text += actual.numero + " ";
                InOrden(actual.der, txt);
            }
        }
        public void PostOrden(Nodo actual, TextBox txt)
        {
            if (actual != null)
            {
                PostOrden(actual.izq, txt);
                PostOrden(actual.der, txt);
                txt.Text += actual.numero + " ";
            }
        }
    }
}
