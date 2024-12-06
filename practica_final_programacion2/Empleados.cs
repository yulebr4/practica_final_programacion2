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
        private void btnGuardar_Click(object sender, EventArgs e)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Botón para modificar un empleado
        private void btnModificar_Click(object sender, EventArgs e)
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

        // Botón para eliminar un empleado
        private void btnEliminar_Click(object sender, EventArgs e)
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
    }
}