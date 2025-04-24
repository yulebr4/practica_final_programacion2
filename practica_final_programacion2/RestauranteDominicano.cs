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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace practica_final_programacion2
{
    public partial class RestauranteDominicano : Form
    {
        private MenuPrincipal _menuPrincipal;

        private readonly NegocioClientes _negocioClientes; // Declaración de _negocioClientes
      

        public RestauranteDominicano()
        {
            InitializeComponent();
            _negocioClientes = new NegocioClientes(); // Inicialización de _negocioClientes
            this.Load += RestauranteDominicano_Load;
   



        }

      

        private void RestauranteDominicano_Load(object sender, EventArgs e)
        {
            try
            {
                var clientes = _negocioClientes.ObtenerClientes(); // Llama al método ObtenerClientes()

                // Poblar el ComboBox con la lista de clientes
                comboBoxClientes.DataSource = clientes;
                comboBoxClientes.DisplayMember = "Nombre"; // Campo que se mostrará en el ComboBox
                comboBoxClientes.ValueMember = "ID"; // Campo asociado al valor seleccionado
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            string clienteSeleccionado = comboBoxClientes.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(clienteSeleccionado))
            {
                // Realizar la lógica de la reservación
                MessageBox.Show($"Reservación exitosa para el cliente");

            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente antes de hacer la reservación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

            {
 
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Form menuPrincipal = Application.OpenForms["MenuPrincipal"]; // Busca el formulario principal por su nombre
            if (menuPrincipal != null)
            {
                menuPrincipal.Show(); // Muestra el menú principal
            }
            this.Hide(); // Cierrrra el formulario secundario

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Minimizar
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
            comboBoxClientes.SelectedIndex = -1; // Limpia la selección
            comboBoxClientes.Text = string.Empty;
        }
    }
}



