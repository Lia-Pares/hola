using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafos
{
    public partial class Form1 : Form
    {
        Grafo g = new Grafo(7);
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            g.Insertar(int.Parse(txt_origen.Text), int.Parse(txt_destino.Text));
            g.ImprimirArista(int.Parse(txt_origen.Text), int.Parse(txt_destino.Text), listBox1);
            txt_origen.Clear();
            txt_destino.Clear();
            txt_origen.Focus();
        }

        private void btn_Matriz_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            g.ImprimirMatriz(richTextBox1);
        }

        private void btn_bfs_Click(object sender, EventArgs e)
        {
            txt_amplitud.Clear();
            g.BFS(txt_amplitud);
        }

        private void btn_DFS_Click(object sender, EventArgs e)
        {
            txt_profundidad.Clear();
            g.DFS(txt_profundidad);
        }

        private void btn_orden_Click(object sender, EventArgs e)
        {
            txt_orden.Clear();
            g.topologico(txt_orden);
        }
    }
}
