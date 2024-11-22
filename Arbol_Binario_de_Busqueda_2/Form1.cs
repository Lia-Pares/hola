using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol_Binario_de_Busqueda_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ABBus aB = new ABBus();
        Nodo raiz;
        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            if(double.TryParse(txt_sueldo.Text,out double su) & su %1 !=0 )
            {
                string[] ca = txt_sueldo.Text.Split('.');
                if (ca[0].Length == 4)
                {
                    if(raiz== null) raiz = aB.Insertar(null, su);
                    else aB.Insertar(raiz, su);
                    treeView1.Nodes.Clear();
                    aB.Mostrar(raiz, treeView1, null);
                    treeView1.ExpandAll();
                    txt_sueldo.Clear();
                    txt_sueldo.Focus();
                }
                else
                {
                    MessageBox.Show("Tiene que haber 4 digitos antes del punto decimal");
                }
            }
            else
            {
                MessageBox.Show("Solo se permiten sueldos en decimal");
            }
        }

        private void btn_PostOrden_Click(object sender, EventArgs e)
        {
            txt_PostOrden.Clear();
            aB.PostOrden(raiz, txt_PostOrden);
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if(aB.Buscar(raiz, double.Parse(txt_sueldo.Text)) != null)
            {
                MessageBox.Show("Existe sueldo");
            }
            else
            {
                MessageBox.Show("No existe sueldo");
            }
            txt_sueldo.Clear();
            txt_sueldo.Focus();
        }
    }
}
