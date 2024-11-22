using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prim
{
    internal class Grafo
    {
        int[,] matriz;
        int numNodos = 7;
        public Grafo()
        {
            matriz = new int[numNodos, numNodos];
        }
        public void Insertar()
        {
            /*matriz[0, 1] = 2;
            matriz[0, 2] = 4;
            matriz[0, 3] = 1;
            matriz[1, 3] = 3;
            matriz[1, 4] = 10;
            matriz[2, 5] = 5;
            matriz[3, 2] = 2;
            matriz[3, 5] = 8;
            matriz[3, 6] = 4;
            matriz[4, 3] = 2;
            matriz[4, 6] = 6;
            matriz[6, 5] = 1;*/
            matriz[0, 1] = 7;
            matriz[1, 2] = 8;
            matriz[1, 3] = 9;
            matriz[1, 4] = 7;
            matriz[2, 4] = 5;
            matriz[2, 5] = 5;
            matriz[3, 2] = 2;
            matriz[3, 5] = 8;
            matriz[3, 6] = 4;
            matriz[4, 3] = 2;
            matriz[4, 6] = 6;
            matriz[6, 5] = 1;
        }
        public List<int[]> Prim()
        {
            List<int[]> ArbolExpasion = new List<int[]>();
            HashSet<int> verticeVisitados = new HashSet<int>();
            int verticeInicial = 0;
            verticeVisitados.Add(verticeInicial);
            while(verticeVisitados.Count < numNodos)
            {
                int[] aristaMinima = null;
                int costoMinimo = int.MaxValue;
                foreach(int i in verticeVisitados)
                {
                    for (int j = 0; j < numNodos; j++) 
                    {
                        if (!verticeVisitados.Contains(j) && matriz[i, j] != 0)
                        {
                            int costoArista = matriz[i, j];
                            if(costoArista < costoMinimo)
                            {
                                aristaMinima = new int[] { i, j };
                                costoMinimo = costoArista;
                            }
                        }
                    }
                }
                ArbolExpasion.Add(aristaMinima);
                verticeVisitados.Add(aristaMinima[1]);
            }
            return ArbolExpasion;
        }
        public void ImprimirMatriz(RichTextBox rich)
        {
            for (int i = 0; i < numNodos; i++)
            {
                for (int j = 0; j < numNodos; j++)
                {
                    rich.Text += matriz[i, j] + "\t";
                }
                rich.Text += "\n";
            }
        }
    }
}
