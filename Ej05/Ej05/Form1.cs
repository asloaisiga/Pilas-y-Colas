using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej05
{
    public partial class Form1 : Form
    {
        // Declaramos una cola tipo string para los clientes
        private Queue<string> colaClientes = new Queue<string>();
        public Form1()
        {
            InitializeComponent();
        }

        // Evento del botón Registrar
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Leemos el nombre ingresado
            string nombre = txtCliente.Text.Trim();

            // Validamos que no esté vacío
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor ingrese un nombre de cliente");
                return;
            }

            // Agregamos el cliente al final de la cola enqueue
            colaClientes.Enqueue(nombre);
            // Limpiamos el TextBox y actualizamos el estado
            txtCliente.Clear();
            lblEstado.Text = $"Cliente '{nombre}' agregado a la cola";
        }

        // Evento del botón Mostrar
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // limpiamos la lista antes de mostrar los clientes
            lstCola.Items.Clear();

            // Si la cola está vacía mostramos un mensaje
            if (colaClientes.Count == 0)
            {
                lblEstado.Text = "La cola está vacía";
                return;
            }

            // Recorremos la cola de primero a ultimo
            foreach (string cliente in colaClientes)
            {
                lstCola.Items.Add(cliente);
            }

            lblEstado.Text = $"Total de clientes en cola: {colaClientes.Count}";
        }

        // Evento del botón Atender
        private void btnAtender_Click(object sender, EventArgs e)
        {
            // Verificamos si hay clientes en la cola
            if (colaClientes.Count == 0)
            {
                MessageBox.Show("No hay clientes en la cola");
                return;
            }

            // Quitamos el primer cliente de la cola dequeue
            string clienteAtendido = colaClientes.Dequeue();
            lblEstado.Text = $"Atendiendo al cliente: {clienteAtendido}";
            btnMostrar_Click(sender, e); // actualiza la lista de clientes
        }
    }
}
