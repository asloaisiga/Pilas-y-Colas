using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Parentesis__3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Btn_salir_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Saliste correctamente");
            Close();
        }

        private void Btn_verificar_Click_1(object sender, EventArgs e)
        {
            string expresion = textBox1.Text;
            Stack<char> pila = new Stack<char>();

            foreach (char c in expresion)
            {
                if (c == '(')
                {
                    pila.Push(c); // Apila el paréntesis de apertura '('
                }
                else if (c == ')')
                {
                    if (pila.Count == 0)
                    {
                        // Verifica si hay más paréntesis que cierran que abren
                        MessageBox.Show("Los paréntesis no están balanceados: Hay más paréntesis que cierran que abren.");
                        return;
                    }
                    pila.Pop(); // Desapila un paréntesis de apertura cuando se encuentra un ')'
                }
            }

            if (pila.Count == 0)
            {
                // Si la pila está vacía, significa que todos los paréntesis están balanceados
                MessageBox.Show("Los paréntesis están correctamente balanceados.");
            }
            else
            {
                // Si quedan elementos en la pila, hay más paréntesis que abren que cierran
                MessageBox.Show("Los paréntesis no están balanceados: Hay más paréntesis que abren que cierran.");
            }
        }
    }
    
}