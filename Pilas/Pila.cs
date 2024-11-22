using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas
{
    internal class Pila
    {
        private Nodo cima = null;
        public void Push(string nom)
        {
            Nodo nuevo = new Nodo();
            nuevo.Valor = nom;
            nuevo.Sgte = cima;
            cima = nuevo;
        }
        public void Mostrar(ListBox list)
        {
            Nodo actual = cima;
            while (actual != null)
            {
                list.Items.Add(actual.Valor);
                actual = actual.Sgte;
            }
        }
        public string Pop()
        {
            if (cima != null)
            {
                string nom = cima.Valor;
                cima = cima.Sgte;
                return nom;
            }
            return null;
        }
        public string Peek()
        {
            if (cima != null)
            {
                return cima.Valor;
            }
            return null;
        }
        public bool EstaVacia()
        {
            return cima == null;
        }
        public int ObtenerPriorida(string operador)
        {
            if (operador == "+" || operador == "-")
                return 1;
            if (operador == "*" || operador == "/") 
                return 2;
            return 0;
        }
        public bool EsOperador(string c)
        {
            return c == "+" || c == "-" || c == "*" || c == "/";
        }
        public string InfijaAprefija(string infija)
        {
            //string prefija = "";
            StringBuilder prefija2 = new StringBuilder();
            for (int i = infija.Length - 1; i >= 0; i--)
            {
                string c = infija[i].ToString();
                if (char.IsLetterOrDigit(infija[i]))
                {
                    prefija2.Insert(0, c);
                }
                else if (c == ")")
                {
                    Push(c);
                }
                else if (c == "(")
                {
                    while(!EstaVacia()&& Peek() != ")")
                    {
                        prefija2.Insert(0, Pop());
                    }
                    Pop();//elimana el ultimo parentesis
                }
                else if (EsOperador(c))
                {
                    while (!EstaVacia() && ObtenerPriorida(Peek())>ObtenerPriorida(c))
                    {
                        prefija2.Insert(0, Pop());
                    }
                    Push(c);
                }
            }
            while (!EstaVacia())
            {
                prefija2.Insert(0, Pop());
            }
            return prefija2.ToString();
        }
        public string InfijaAposfija(string infija)
        {
            //string prefija = "";
            StringBuilder posfija2 = new StringBuilder();
            for (int i = 0; i < infija.Length; i++)
            {
                string c = infija[i].ToString();
                if (char.IsLetterOrDigit(infija[i]))
                {
                    posfija2.Append(c);
                }
                else if (c == "(")
                {
                    Push(c);
                }
                else if (c == ")")
                {
                    while (!EstaVacia() && Peek() != "(")
                    {
                        posfija2.Append(Pop());
                    }
                    Pop();//elimana el ultimo parentesis
                }
                else if (EsOperador(c))
                {
                    while (!EstaVacia() && ObtenerPriorida(Peek()) > ObtenerPriorida(c))
                    {
                        posfija2.Append(Pop());
                    }
                    Push(c);
                }
            }
            while (!EstaVacia())
            {
                posfija2.Append(Pop());
            }
            return posfija2.ToString();
        }
    }
}
