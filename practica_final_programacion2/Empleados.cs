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
    public partial class Empleados : Form
    {
        private readonly NegocioEmpleados negocio = new NegocioEmpleados();

        public Empleados()
        {
            InitializeComponent();
        }

        // Método para cargar los datos en el DataGridView
        private void CargarDatos()
        {
            dgvEmpleados.DataSource = negocio.MostrarDatos();
        }

        // Evento al cargar el formulario
        private void Empleados_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        // Botón para guardar un nuevo empleado


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form menuPrincipal = Application.OpenForms["MenuPrincipal"];

            if (menuPrincipal != null)
            {
                menuPrincipal.Show(); // Muestra el menú principal
            }

            this.Close(); // Cierra el formulario secundario
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal; // Restaurar
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            Form menuPrincipal = Application.OpenForms["MenuPrincipal"]; // Busca el formulario principal por su nombre
            if (menuPrincipal != null)
            {
                menuPrincipal.Show(); // Muestra el menú principal
            }
            this.Close(); // Cierra el formulario secundario
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y la tecla de retroceso
            // Permitir solo números, un punto decimal y la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;

            }
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

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
           try
    {
                EntidadEmpleados dat = new EntidadEmpleados
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Puesto = txtPuesto.Text,
                    Salario = decimal.Parse(txtSalario.Text)
                };

                negocio.Guardar(dat);
                MessageBox.Show("Empleado guardado correctamente.");
                CargarDatos();
                LimpiarCampos(); // Llamar al método para limpiar los campos
            }
                catch (Exception ex)
    {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmpleados.SelectedRows.Count > 0)
                {
                    EntidadEmpleados dat = new EntidadEmpleados
                    {
                        ID = (int)dgvEmpleados.SelectedRows[0].Cells["ID"].Value,
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Puesto = txtPuesto.Text,
                        Salario = decimal.Parse(txtSalario.Text)

                    };

                    negocio.Modificar(dat);
                    MessageBox.Show("Empleado modificado correctamente.");
                    CargarDatos();

                }
                else
                {
                    MessageBox.Show("Seleccione un empleado para modificar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmpleados.SelectedRows.Count > 0)
                {
                    int id = (int)dgvEmpleados.SelectedRows[0].Cells["ID"].Value;
                    negocio.Eliminar(id);
                    MessageBox.Show("Empleado eliminado correctamente.");
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("Seleccione un empleado para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtSalario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, un punto decimal y la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtPuesto_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtPuesto.Text = "";
            txtSalario.Text = "";
        }
    }
}
    
    
    
