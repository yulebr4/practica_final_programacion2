using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatosLogin
    {
       
            public bool Login(string usuario, string contrasena)
            {
                // Simulación de credenciales válidas (sin base de datos)
                string usuarioValido = "admin";
                string contrasenaValida = "admin123";

                // Validar credenciales
                return usuario == usuarioValido && contrasena == contrasenaValida;
            }
        }
    }
