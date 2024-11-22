using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol_Binario_de_Busqueda_3
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
        ABB_3 abb = new ABB_3();
        Nodo raiz;
        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            if(byte.TryParse(txt_numero.Text, out byte num))
            {
                if(raiz == null) raiz = abb.Insertar(null, num);
                else abb.Insertar(raiz, num);
                treeView1.Nodes.Clear();
                abb.Mostrar(raiz, treeView1, null);
                treeView1.ExpandAll();
                txt_numero.Clear();
                txt_numero.Focus();
            }
            else
            {
                MessageBox.Show("Ingrese números enteros entre 0 -255");
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (byte.TryParse(txt_numero.Text, out byte num))
            {
                raiz = abb.Eliminar(raiz, num);
                treeView1.Nodes.Clear();
                abb.Mostrar(raiz, treeView1, null);
                treeView1.ExpandAll();
                txt_numero.Clear();
                txt_numero.Focus();
            }
            else
            {
                MessageBox.Show("Ingrese números enteros entre 0 -255");
            }
        }

        private void btn_Minimo_Click(object sender, EventArgs e)
        {
            if (raiz != null)
            {
                MessageBox.Show("Minimo: " + abb.Minimo(raiz));
            }
        }

        private void btn_Maximo_Click(object sender, EventArgs e)
        {
            if (raiz != null)
            {
                MessageBox.Show("Minimo: " + abb.maximo(raiz));
            }
        }

        private void btn_Altura_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Altura: " + abb.Altura(raiz));
        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (byte.TryParse(txt_numero.Text, out byte num))
            {
                if (abb.Buscar(raiz, num) != null) MessageBox.Show($"Número {num} Existe");
                else MessageBox.Show("No Existe");
                txt_numero.Clear();
                txt_numero.Focus();
            }
            else
            {
                MessageBox.Show("Ingrese números enteros entre 0 -255");
            }
        }

        private void btn_Generar_Recorrido_Click(object sender, EventArgs e)
        {
            txt_preorden.Clear();
            txt_inorden.Clear();
            txt_postorden.Clear();

            abb.PreOrden(raiz, txt_preorden);
            abb.InOrden(raiz, txt_inorden);
            abb.PostOrden(raiz, txt_postorden);
        }
    }
}
