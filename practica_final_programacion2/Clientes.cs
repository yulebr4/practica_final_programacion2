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
            this.Hide();

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

                // Guardar cliente a través de la capa de negocio
                bool guardadoExitoso = _negocioClientes.GuardarCliente(nuevoCliente);

                if (guardadoExitoso)
                {
                    MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Hubo un error al guardar el cliente. Por favor, inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}\n\nExcepción interna: {ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCargo.Text = string.Empty;
        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {

            Form menuPrincipal = Application.OpenForms["MenuPrincipal"]; // Busca el formulario principal por su nombre
            if (menuPrincipal != null)
            {
                menuPrincipal.Show(); // Muestra el menú principal
            }
            this.Close(); // Cierra el formulario secundario
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal; // Restaurar
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {


            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized; // Maximizar
            }
            else
            {
                this.WindowState = FormWindowState.Normal; // Restaurar
            }
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

            Form menuPrincipal = Application.OpenForms["MenuPrincipal"]; // Busca el formulario principal por su nombre
            if (menuPrincipal != null)
            {
                menuPrincipal.Show(); // Muestra el menú principal
            }
            this.Close(); // Cierra el formulario secundario
        }

        private void btnAgregar_Click_2(object sender, EventArgs e)
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

                // Guardar cliente a través de la capa de negocio
                bool guardadoExitoso = _negocioClientes.GuardarCliente(nuevoCliente);

                if (guardadoExitoso)
                {
                    MessageBox.Show("Cliente agregado correctamente. Ya se puede utilizar para Reservar Excursiones y Restaurantes ", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();

                    // Volver al menú principal
                    Form menuPrincipal = Application.OpenForms["MenuPrincipal"]; // Busca el formulario principal por su nombre
                    if (menuPrincipal != null)
                    {
                        menuPrincipal.Show(); // Muestra el menú principal
                    }
                    this.Close(); // Cierra el formulario actual
                }
                else
                {
                    MessageBox.Show("Hubo un error al guardar el cliente. Por favor, inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}\n\nExcepción interna: {ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

    }
    
    
}
