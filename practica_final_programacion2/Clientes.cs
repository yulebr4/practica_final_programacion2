using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_final_programacion2
{
    public partial class Clientes : Form
    {
        private readonly NegocioClientes _negocioClientes;

        public Clientes()
        {
            InitializeComponent();
            _negocioClientes = new NegocioClientes();

            // Asignar evento Load al formulario
            this.Load += Form1_Load;
        }

        // Evento Form1_Load
        private void Form1_Load(object sender, EventArgs e)
        {
            // Aquí puedes inicializar datos o configuraciones al cargar el formulario
            // Por ejemplo: cargar clientes en un DataGridView (si decides implementarlo más adelante)
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Crear la entidad de cliente desde los campos del formulario
                var nuevoCliente = new EntidadClientes
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Email = txtEmail.Text,
                    Telefono = txtTelefono.Text
                };

                // Guardar cliente
                _negocioClientes.GuardarCliente(nuevoCliente);

                // Mostrar mensaje de éxito
                MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Opcional: Limpiar los campos del formulario después de agregar el cliente
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método opcional para limpiar los campos del formulario
        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }

    }
}
