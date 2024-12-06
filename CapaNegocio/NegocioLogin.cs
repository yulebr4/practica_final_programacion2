using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioLogin
    {
       
        private DatosLogin _datosLogin;

        public NegocioLogin()
        {
            _datosLogin = new DatosLogin();
        }

        public bool Login(string usuario, string contrasena)
        {
            // Validar credenciales en la capa de datos
            return _datosLogin.Login(usuario, contrasena);
        }
    }
}