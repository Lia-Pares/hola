using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafos_Dirigidos
{
    internal class Grafo
    {
        int[,] matrizCosto;
        int numNodos;
        public Grafo(int numNodos)
        {
            this.numNodos = numNodos;
            matrizCosto= new int[numNodos,numNodos];
        } 
        public void Insertar(int o, int d, int c)
        {
            matrizCosto[o,d] = c;
        }
        public void imprimirArista(int o, int d, int c, ListBox list)
        {
            list.Items.Add($"{o} | {d} | {c}");
        }
        public void imprimirMatriz(RichTextBox rich)
        {
            for(int i = 0; i < numNodos ; i++)
            {
                for (int j = 0; j < numNodos; j++)
                {
                    rich.Text += matrizCosto[i, j] + "\t";
                }
                rich.Text += "\n";
            }
        }
        public int minDistancia(int[] distancias, bool[] visitados)
        {
            int min = int.MaxValue;
            int minIndex = -1;
            for (int i = 0;i < numNodos ; i++)
            {
                if(!visitados[i]&& distancias[i]<= min)
                {
                    min = distancias[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }
        public void dijkstra(int origen,ListBox list)
        {
            int[] distancias = new int[numNodos]; 
            bool[] visitados = new bool[numNodos];
            for (int i = 0; i < numNodos; i++)
            {
                distancias [i] = int.MaxValue;
                visitados [i] = false;
            }
            distancias[origen] = 0;
            for(int j = 0;j < numNodos; j++)
            {
                int min = minDistancia(distancias, visitados);
                visitados[min] = true;
                if(!visitados[j] && matrizCosto[min,j] != 0 && distancias[min] != int.MaxValue && distancias[min] + matrizCosto[min, j] < distancias[j])
                {
                    distancias[j] = distancias[min] + matrizCosto [min,j];
                }
            }
            //Imprimir distancias minimas
            list.Items.Add("Origen\tDistancia\tDistancia mínima");
            for(int i = 0;i < numNodos;i++)
            {
                if (distancias[i] == int.MaxValue)
                    list.Items.Add($"{origen}\t{i}\tINF");
                else
                    list.Items.Add($"{origen}\t{i}\t{distancias[i]}");
            }
        }
    }
}
