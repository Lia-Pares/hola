using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafos
{
    class Grafo
    {
        private int[,] matrizAdyacente;
        private int numNodos;
        public Grafo(int numNodo)
        {
            numNodos = numNodo;
            matrizAdyacente = new int[numNodos, numNodo];
        }
        public void Insertar(int origen, int destino)
        {
            matrizAdyacente[origen, destino] = 1;
        }
        public void ImprimirArista(int origen, int destino, ListBox list)
        {
            list.Items.Add($"{origen} , {destino}");
        }
        public void ImprimirMatriz(RichTextBox rich)
        {
            for(int i=0; i < numNodos; i++)
            {
                for (int j = 0; j < numNodos; j++)
                {
                    rich.Text += matrizAdyacente[i, j] + "\t";
                }
                rich.Text += "\n";
            }
        }
        public void BFS(TextBox txt)
        {
            int nodoInicio = 0;
            bool[] visitado = new bool[numNodos];
            Queue<int> cola = new Queue<int>();

            visitado[nodoInicio] = true;
            cola.Enqueue(nodoInicio);
            while(cola.Count != 0)
            {
                int nodoActual = cola.Dequeue();
                txt.Text += nodoActual + " ";
                for(int i = 0; i < numNodos; i++)
                {
                    if (matrizAdyacente[nodoActual, i]== 1 && !visitado[i])
                    {
                        visitado[i] = true;
                        cola.Enqueue(i);
                    }
                }
            }
        }
        public void DFS(TextBox txt)
        {
            int nodoInicio = 0;
            bool[] visitado = new bool[numNodos];
            Stack<int> pila = new Stack<int>();

            pila.Push(nodoInicio);
            while (pila.Count != 0)
            {
                int nodoActual = pila.Pop();
                if (!visitado[nodoActual])
                {
                    visitado[nodoActual] = true;
                    txt.Text += nodoActual + " ";
                    for (int i = numNodos -1; i >= 0; i--)
                    {
                        if (matrizAdyacente[nodoActual, i] == 1 && !visitado[i])
                        {
                            pila.Push(i);
                        }
                    }
                }
            }
        }
        public void DFS2(int nodo, bool[] visitado, Stack<int> pila)
        {
            visitado[nodo] = true;
            for(int i = 0; i < numNodos; i++)
            {
                if(matrizAdyacente[nodo, i] == 1 && !visitado[i])
                {
                    DFS2(i, visitado, pila);
                }
            }
            pila.Push(nodo);
        }
        public void topologico(TextBox txt)
        {
            Stack<int> pila = new Stack<int>();
            bool[] visitado = new bool[numNodos];
            for (int i = 0; i < numNodos; i++)
            {
                if (!visitado[i])
                {
                    DFS2(i, visitado, pila);
                }
            }
            while (pila.Count > 0)
            {
                txt.Text += pila.Pop() + " ";
            }
        }
    }
}
