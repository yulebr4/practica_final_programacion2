using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;

namespace practica_final_programacion2
{
    public partial class Hacienda : Form
    {
        private readonly NegocioClientes _negocioClientes;

        //velo ahi
        public Hacienda()
        {
            InitializeComponent();
            _negocioClientes = new NegocioClientes();
            this.Load += Hacienda_Load;
        }

        private void Hacienda_Load(object sender, EventArgs e)
        {
            try
            {
                var clientes = _negocioClientes.ObtenerClientes();
                comboBoxClientes.DataSource = clientes;
                comboBoxClientes.DisplayMember = "Nombre";
                comboBoxClientes.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form menuPrincipal = Application.OpenForms["MenuPrincipal"];
            if (menuPrincipal != null)
            {
                menuPrincipal.Show();
            }
            this.Close();
        }

        private async void btnReservar_Click(object sender, EventArgs e)
        {
            {
                btnReservar.Enabled = false; // Deshabilitar el botón mientras se procesa la reserva
                btnReservar.Text = "Procesando...";

                try
                {
                    string clienteSeleccionado = comboBoxClientes.Text;
                    int clienteID = Convert.ToInt32(comboBoxClientes.SelectedValue);

                    if (!string.IsNullOrEmpty(clienteSeleccionado))
                    {
                        await ReservarExcursionAsync(clienteID, clienteSeleccionado);
                        MessageBox.Show("Excursión reservada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Redirigir al menú principal después de una reserva exitosa
                        Form menuPrincipal = Application.OpenForms["MenuPrincipal"];
                        if (menuPrincipal != null)
                        {
                            menuPrincipal.Show(); // Muestra el formulario principal
                        }
                        this.Close(); // Cierra el formulario actual
                    }
                    else
                    {
                        MessageBox.Show("Por favor, selecciona un cliente antes de hacer la reservación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al realizar la reserva: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    btnReservar.Enabled = true; // Habilitar nuevamente el botón
                    btnReservar.Text = "Reservar";
                }
            }
        }

            private async Task ReservarExcursionAsync(int clienteID, string clienteSeleccionado)
        {
            // Simula un retraso en el proceso de reserva (opcional, para reflejar operaciones reales)
            await Task.Delay(4000);

            // Lógica para agregar la cita a la lista compartida
            DatosCompartidos.Citas.Add(new Cita
            {
                ClienteID = clienteID,
                NombreCliente = clienteSeleccionado,
                Excursion = "Hacienda",
                Fecha = DateTime.Now
            });
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal; // Restaurar
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form menuPrincipal = Application.OpenForms["MenuPrincipal"]; // Busca el formulario principal por su nombre
            if (menuPrincipal != null)
            {
                menuPrincipal.Show(); // Muestra el menú principal
            }
            this.Close(); // Cierra el formulario secundario
        }

        private void comboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            comboBoxClientes.Text = string.Empty;
        }
    }
}