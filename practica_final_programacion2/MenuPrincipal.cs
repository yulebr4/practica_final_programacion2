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
    public partial class MenuPrincipal : Form
    {
        private Clientes formularioClientes;

        private Empleados formularioEmpleados;
        public MenuPrincipal()
        {

            InitializeComponent();
            customizeDesing();
            formularioClientes = new Clientes();
            formularioEmpleados = new Empleados();

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void customizeDesing()
        {
            panelSubMenuCitas.Visible = false;
            panelSubMenuClientes.Visible = false;
            panelSubMenuExcursiones.Visible = false;
            panelSubMenuRestaurantes.Visible = false;


        }

        private void hideSubMenu()
        {


            if (panelSubMenuClientes.Visible == true)
                panelSubMenuClientes.Visible = false;

            if (panelSubMenuExcursiones.Visible == true)
                panelSubMenuExcursiones.Visible = false;

            if (panelSubMenuRestaurantes.Visible == true)
                panelSubMenuRestaurantes.Visible = false;



        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }

            else
                subMenu.Visible = false;

        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuCitas);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuClientes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formularioClientes.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (formularioEmpleados == null || formularioEmpleados.IsDisposed)
                {
                    formularioEmpleados = new Empleados();
                }
                formularioEmpleados.Show(); // Usa Show para que sea una ventana independiente
            }
        }
    }
}
