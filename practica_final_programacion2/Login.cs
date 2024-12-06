using CapaNegocio; // Asegúrate de agregar esta referencia
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_final_programacion2
{
    public partial class Login : Form
    {

        private NegocioLogin _negocioLogin;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Inicializar la instancia de NegocioLogin cuando el formulario cargue
            _negocioLogin = new NegocioLogin();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturamos los datos ingresados por el usuario
                string usuario = txtUsuario.Text;
                string contrasena = txtContraseña.Text;

                // Validar credenciales
                bool loginExitoso = _negocioLogin.Login(usuario, contrasena);

                if (loginExitoso)
                {
                    MessageBox.Show("¡Login exitoso!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Abrir el formulario principal (MenuStrip)
                    MenuPrincipal menu = new MenuPrincipal();
                    menu.Show();

                    // Ocultar el formulario de login
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = false;
            chkShowPassword.Checked = false;
        }


    }
}