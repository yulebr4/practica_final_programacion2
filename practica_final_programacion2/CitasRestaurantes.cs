using CapaDatos;
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
    public partial class CitasRestaurantes : Form
    {
        private MenuPrincipal _menuPrincipal;

        public CitasRestaurantes()
        {
            InitializeComponent();
        }

        public CitasRestaurantes(MenuPrincipal menuPrincipal)
        {
            InitializeComponent();
            _menuPrincipal = menuPrincipal; // Guarda la referencia del formulario principal si la necesitas
        }

        private void CitasRestaurantes_Load(object sender, EventArgs e)
        {
            {
                try
                {
                    // Ordenar las citas alfabéticamente por el nombre del cliente
                    var citasOrdenadas = DatosCompartidos.Citas
                        .OrderBy(c => c.NombreCliente)
                        .ToList();

                    // Asignar las citas ordenadas al DataGridView
                    dgvCitas.DataSource = null; // Limpia cualquier dato anterior
                    dgvCitas.DataSource = citasOrdenadas;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar las citas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            {
                // Muestra el formulario principal (pasado como referencia)
                Form menuPrincipal = Application.OpenForms["MenuPrincipal"]; // Busca el formulario principal por su nombre
                if (menuPrincipal != null)
                {
                    menuPrincipal.Show(); // Muestra el menú principal
                }
                this.Close(); // Cierra el formulario secundario
            }


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

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
