using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej06
{
    public partial class ColaImpresión : Form
    {
        // Cola donde voy a guardar los documentos
        private Queue<string> colaImpresion = new Queue<string>();
        public ColaImpresión()
        {
            InitializeComponent();
            // Conecto los botones con sus funciones
            btnAgregar.Click += btnAgregar_Click;
            btnImprimir.Click += btnImprimir_Click;

            // Muestro al iniciar el texto por defecto
            ActualizarLista();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Por favor ingrese un nombre de documento.");
                return;
            }
            

                // Encolo el documento ingresado
                colaImpresion.Enqueue(nombre);

            // Limpio el textbox para seguir agregando rápido
            txtNombre.Clear();
            txtNombre.Focus();

            // Actualizo la lista para que se vea el nuevo documento
            ActualizarLista();

        }
        // Botón para simular la impresión
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (colaImpresion.Count == 0)
            {
                MessageBox.Show("No hay documentos para imprimir.");
                return;
            }

            // Quito el primer documento de la cola
            string documento = colaImpresion.Dequeue();

            // Muestro mensaje simulando impresión
            MessageBox.Show("Imprimiendo documento: " + documento);

            // Actualizo la lista mostrando lo que queda
            ActualizarLista();
        }
        // Esta función muestra los documentos en el ListBox
        private void ActualizarLista()
        {
            // Actualizar título de la ventana
            this.Text = "Cola de Impresión – Pendientes: " + colaImpresion.Count;

            // Actualizar label de pendientes
            lblPendientes.Text = "Documentos pendientes: " + colaImpresion.Count;

            // Cambiar color según cantidad
            if (colaImpresion.Count == 0)
                lblPendientes.ForeColor = Color.Black;      // Sin pendientes
            else if (colaImpresion.Count <= 3)
                lblPendientes.ForeColor = Color.Green;     // Pocos
            else if (colaImpresion.Count <= 6)
                lblPendientes.ForeColor = Color.DarkOrange; // Moderado
            else
                lblPendientes.ForeColor = Color.Red;       // Muchos (alerta)

            // Actualizar ListBox
            lstCola.Items.Clear();

            if (colaImpresion.Count == 0)
            {
                lstCola.Items.Add("No hay documentos en cola.");
            }
            else
            {
                foreach (var doc in colaImpresion)
                {
                    lstCola.Items.Add(doc);
                }
            }
        }
    }
}
