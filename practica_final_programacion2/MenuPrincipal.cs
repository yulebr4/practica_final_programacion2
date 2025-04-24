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

        private CitasRestaurantes formularioCitasRestaurantes;

        private RestauranteItaliano formularioRestauranteItaliano;

        private RestauranteMexicano formularioRestauranteMexicano;

        private RestauranteDominicano formularioRestauranteDominicano;

        private Buggies formularioBuggies;

        private Hacienda formularioHacienda;

        private NadoconDelfines formularioNadoconDelfines;
        public MenuPrincipal()
        {

            InitializeComponent();
            customizeDesing();
            formularioClientes = new Clientes();
            formularioEmpleados = new Empleados();
            formularioCitasRestaurantes = new CitasRestaurantes();
            formularioRestauranteItaliano = new RestauranteItaliano();
            formularioRestauranteMexicano = new RestauranteMexicano();
            formularioRestauranteDominicano = new RestauranteDominicano();
            formularioBuggies = new Buggies();
            formularioHacienda = new Hacienda();
            formularioNadoconDelfines = new NadoconDelfines();
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
            if (formularioCitasRestaurantes == null || formularioCitasRestaurantes.IsDisposed)
            {
                formularioCitasRestaurantes = new CitasRestaurantes(); // Crea una nueva instancia
            }

            formularioCitasRestaurantes.Show(); // Muestra el formulario
            this.Hide(); // Opcional: Oculta el formulario principal
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuRestaurantes);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuClientes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (formularioClientes == null || formularioClientes.IsDisposed)
            {
                formularioClientes = new Clientes(); // Crea una nueva instancia si es necesario
            }

            formularioClientes.Show(); // Usa Show en lugar de ShowDialog
            this.Hide(); // Oculta el menú principal

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (formularioEmpleados == null || formularioEmpleados.IsDisposed)
                {
                    formularioEmpleados = new Empleados();
                }
                formularioEmpleados.Show(); // Usa Show para que sea una ventana independiente
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            

            if (formularioRestauranteItaliano == null || formularioRestauranteItaliano.IsDisposed)
            {
                formularioRestauranteItaliano = new RestauranteItaliano();
            }
            formularioRestauranteItaliano.Show(); // Usa Show para que sea una ventana independiente
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (formularioRestauranteMexicano == null || formularioRestauranteMexicano.IsDisposed)
            {
                formularioRestauranteMexicano = new RestauranteMexicano();
            }
            formularioRestauranteMexicano.Show(); // Usa Show para que sea una ventana independiente
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            {
                // Asegúrate de reutilizar la instancia de formularioCitasRestaurantes si ya existe
                if (formularioRestauranteDominicano == null || formularioRestauranteDominicano.IsDisposed)
                {
                    formularioRestauranteDominicano = new RestauranteDominicano();
                }

                formularioRestauranteDominicano.Show(); 
                this.Hide();


            }
        }

        private void btnExcursiones_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuExcursiones);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (formularioBuggies == null || formularioBuggies.IsDisposed)
            {
                formularioBuggies = new Buggies();
            }

            formularioBuggies.Show(); 
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (formularioHacienda == null || formularioHacienda.IsDisposed)
            {
                formularioHacienda = new Hacienda();
            }

            formularioHacienda.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (formularioNadoconDelfines == null || formularioNadoconDelfines.IsDisposed)
            {
                formularioNadoconDelfines = new NadoconDelfines();
            }

            formularioNadoconDelfines.Show();
            this.Hide();
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
            Application.Exit(); // Cierra el programa completo
        }
    }
}
