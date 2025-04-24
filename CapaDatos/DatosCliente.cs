using System;
using System.Collections.Generic;
using System.Linq;

namespace CapaDatos
{
    public class DatosClientes
    {
       
        private readonly LaYuleTravelsEntities2 _context;

        public DatosClientes()
        {
            _context = new LaYuleTravelsEntities2(); // Tu clase DbContext
        }

        public bool AgregarCliente(Cliente cliente)
        {
            try
            {
                _context.Clientes.Add(cliente); // Agregar el cliente a la base de datos
                _context.SaveChanges(); // Guardar los cambios en la base de datos
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al agregar el cliente: {ex.Message}", ex);
            }
        }

        public List<Cliente> ObtenerClientes()
        {
            try
            {
                return _context.Clientes.ToList(); // Retorna todos los clientes
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener los clientes: {ex.Message}", ex);
            }
        }
    }
}