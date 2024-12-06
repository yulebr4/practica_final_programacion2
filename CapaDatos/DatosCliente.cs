using System;
using System.Collections.Generic;
using System.Linq;

namespace CapaDatos
{
    public class DatosClientes
    {
        private readonly LaYuleTravelsEntities2 _context;

        // Constructor
        public DatosClientes()
        {
            try
            {
                // Inicializar el contexto sin pasar la cadena de conexión como parámetro
                _context = new LaYuleTravelsEntities2();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }
                throw;
            }
        }

        public bool AgregarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ObtenerClientes()
        {
            try
            {
                return _context.Clientes.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener los clientes: {ex.Message}", ex);
            }
        }
    }
}