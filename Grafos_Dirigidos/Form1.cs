using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafos_Dirigidos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Grafo g;
        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txt_Vertices.Text, out int verti) || verti > 0)
            {
                g = new Grafo(verti);
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                richTextBox1.Clear();
                MessageBox.Show("#Vértices" + verti);
            }
            else
            {
                MessageBox.Show("Solo números enteros.");
            }
        }

        private void btn_Insertar_N_Click(object sender, EventArgs e)
        {
            if (g != null)
            {
                int origen = int.Parse(txt_Origen.Text);
                int destino = int.Parse(txt_Destino.Text);
                int costo = int.Parse(txt_Costo.Text);
                g.Insertar(origen, destino, costo);
                g.imprimirArista(origen, destino, costo, listBox1);
            }
            else
            {
                MessageBox.Show("Primero define el numero de vértices");
            }
        }

        private void btn_Matriz_de_Cosoto_Click(object sender, EventArgs e)
        {
            if (g != null)
            {
                richTextBox1.Clear();
                g.imprimirMatriz(richTextBox1);
            }
            else
            {
                MessageBox.Show("Primero define el numero de vértices");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (g != null)
            {
                listBox2.Items.Clear();
                g.dijkstra(0,listBox2);
            }
            else
            {
                MessageBox.Show("Primero define el numero de vértices!");
            }
        }
    }
}
