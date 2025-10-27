using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej02
{
    public partial class Form1 : Form
    {
        // Declaramos una pilo de tipo string
        private Stack<string> pilaPalabras = new Stack<string>();
        public Form1()
        {
            InitializeComponent();
        }

        // Evento del botón Agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Guardamos la palabra escrita en el TextBox
            string palabra = txtPalabra.Text.Trim();

            // Validamos que no esté vacía
            if (string.IsNullOrEmpty(palabra))
            {
                MessageBox.Show("Por favor, ingrese una palabra");
                return;
            }

            //if (pilaPalabras.Count >= 5)
            //{
            //    MessageBox.Show("Ya se ingresaron 5 palabras, no se pueden agregar más");
            //    return;
            //}

            // Insertamos push la palabra de la pila
            pilaPalabras.Push(palabra);
            // Limpiamos el TextBox
            txtPalabra.Clear();
            lblMensaje.Text = $"Palabra '{palabra}' agregada";
        }

        // Evento del botón Mostrar
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // Limpiamos el ListBox antes de mostrar las palabras
            lstPila.Items.Clear();

            // Si la pila está vacía mostramos un mensaje
            if (pilaPalabras.Count == 0)
            {
                MessageBox.Show("La pila está vacía");
                return;
            }

            // Recorremos la pila muestra de útlimo a primero
            foreach (string palabra in pilaPalabras)
            {
                lstPila.Items.Add(palabra);
            }

            lblMensaje.Text = $"Total de palabras en pila: {pilaPalabras.Count}";
        }

        // Evento del botón Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Si la pila está vacía mostramos un mensaje
            if (pilaPalabras.Count == 0)
            {
                MessageBox.Show("La pila está vacía, no hay nada que eliminar");
                return;
            }

            //Quitamos pop la palabra de la cima de la pila
            string palabraEliminada = pilaPalabras.Pop();
            // Mostramos la palabra eliminada
            lblMensaje.Text = $"Se elimin la palabra: {palabraEliminada}";
            btnMostrar_Click(sender, e); // actualiza la lista
        }
    }
}
