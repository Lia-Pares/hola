using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Lista li = new Lista();
        Pila  pi = new Pila();
        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            string pre = pi.InfijaAprefija(txt_Numero.Text);
            string pos = pi.InfijaAposfija(txt_Numero.Text);

            listView1.Items.Clear();
            li.Insertar(txt_Numero.Text,pre,pos);
            li.Mostrar(listView1);
            txt_Numero.Clear();
            txt_Numero.Focus();
        }
    }
}
