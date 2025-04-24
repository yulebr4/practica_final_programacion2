using CapaNegocio; // Asegúrate de agregar esta referencia
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_final_programacion2
{
    public partial class Login : Form
    {
        private readonly NegocioLogin _negocioLogin;

        public Login()
        {
            InitializeComponent();
            _negocioLogin = new NegocioLogin();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Asegurarse de que la contraseña esté oculta y el checkbox desmarcado
            txtContraseña.UseSystemPasswordChar = false;
            chkShowPassword.Checked = false;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false; // Deshabilitar botón para prevenir múltiples clics

            try
            {

                btnLogin.Enabled = false;
                btnLogin.Text = "Procesando...";
                Cursor = Cursors.WaitCursor;

                string usuario = txtUsuario.Text.Trim();
                string contrasena = txtContraseña.Text;

                // Validar que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
                {
                    MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Cursor.Current = Cursors.WaitCursor; // Mostrar indicador de carga opcional

                // Llamar al método ValidarLoginAsync para validar credenciales
                bool loginExitoso = await ValidarLoginAsync(usuario, contrasena);

                if (loginExitoso)
                {
                    MessageBox.Show("¡Login exitoso!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MenuPrincipal menu = new MenuPrincipal();
                    menu.Show();
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
            finally
            {
                btnLogin.Enabled = true; // Restaurar estado del botón
                Cursor.Current = Cursors.Default; // Restaurar cursor
            }
        }

        private async Task<bool> ValidarLoginAsync(string usuario, string contrasena)
        {
            // Simula un retraso asíncrono para mostrar el proceso (3 segundo)
            await Task.Delay(3000);

            // Lógica de validación original
            return _negocioLogin.Login(usuario, contrasena);
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Alternar visibilidad de la contraseña según el estado del checkbox
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            // Agregar manejo de tecla Enter para iniciar sesión
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}