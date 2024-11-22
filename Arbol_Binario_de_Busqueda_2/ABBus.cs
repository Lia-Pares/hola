using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol_Binario_de_Busqueda_2
{
    internal class ABBus
    {
        int cant = 0;
        public Nodo Insertar(Nodo actual, double su)
        {
            Nodo nuevo = new Nodo(su);
            if (actual == null)
            {
                cant++;
                return nuevo; 
            }
            if (su < actual.sueldo) actual.izq = Insertar(actual.izq, su);
            else if (su > actual.sueldo) actual.der = Insertar(actual.der, su);
            else MessageBox.Show("No se puede repetir los sueldos");
            return actual;
        }
        public void Mostrar(Nodo actual, TreeView tree, TreeNode padre)
        {
            if (actual != null)
            {
                TreeNode cabeRaiz = new TreeNode(actual.sueldo.ToString());
                if (padre == null) tree.Nodes.Add(cabeRaiz);
                else padre.Nodes.Add(cabeRaiz);
                if (actual.izq != null) Mostrar(actual.izq, tree, cabeRaiz);
                if (actual.der != null) Mostrar(actual.der, tree, cabeRaiz);
            }
        }
        public void PostOrden(Nodo actual, TextBox text)
        {
            if (cant > 3)
            {
                if (actual.izq != null) PostOrden(actual.izq, text);
                if (actual.der != null) PostOrden(actual.der, text);
                text.Text += actual.sueldo + " ";
            }
            else
            {
                MessageBox.Show("Inserta por lo menos 4 sueldos!");
            }
        }
        public Nodo Buscar(Nodo actual, double su)
        {
            while (actual != null)
            {
                if (su == actual.sueldo) return actual;
                else if (su < actual.sueldo) actual = actual.izq;
                else actual = actual.der;
            }
            return null;
        }
    }
}
