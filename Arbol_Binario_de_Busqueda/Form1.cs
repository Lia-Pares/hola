using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol_Binario_de_Busqueda
{
    public partial class Form1 : Form
    {
        ArbolBB miarbol = new ArbolBB();
        Nodo raiz;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_numero.Text, out int num))
            {
                if (raiz == null)
                {
                    raiz = miarbol.Insertar(null, num);
                }
                else
                {
                    miarbol.Insertar(raiz, num);
                }
                treeView1.Nodes.Clear();
                miarbol.Mostrar(raiz, treeView1, null);
                treeView1.ExpandAll();
                txt_numero.Clear();
                txt_numero.Focus();
            }
            else
            {
                MessageBox.Show("Solo permiten numeros enteros!");
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_numero.Text, out int num))
            {
                if (miarbol.Buscar(raiz, num) != null)
                {
                    MessageBox.Show($"Nodo {num} existe");
                }
                else
                {
                    MessageBox.Show($"Nodo {num} no existe");
                }
                txt_numero.Clear();
                txt_numero.Focus();
            }
            else
            {
                MessageBox.Show("Solo permiten numeros enteros!");
            }
        }

        private void btn_Generar_Recorrido_Click(object sender, EventArgs e)
        {
            txt_pre.Clear();
            miarbol.PreOrden(raiz, txt_pre);
            miarbol.InOrden(raiz, txt_in);
            miarbol.PostOrden(raiz, txt_post);
        }
    }
}
