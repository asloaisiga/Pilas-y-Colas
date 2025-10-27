using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pila1
{
    public partial class Form1 : Form
    {
        Stack<int> enteros = new Stack<int>();
       
        public Form1()

        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int.TryParse(tbEnteros.Text, out int numeros);
            enteros.Push(numeros);

            Mostrar();
            tbEnteros.Clear();
            tbEnteros.Focus();
        }

        public void Mostrar()
        {
            lbEnteros.Items.Clear();
            foreach (int numero in enteros)
            {
                lbEnteros.Items.Add(numero);
            }
            return;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (enteros.Count > 0)
            {
                enteros.Pop();
                Mostrar();
            }
            else if (enteros.Count == 0)
            {
                MessageBox.Show("YA NO HAY MAS ELEMENTOS QUE SACAR DE LA PILA", "Pila vacia");
            }
        }

       
    }
}

