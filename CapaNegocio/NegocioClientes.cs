using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using CapaNegocio;

namespace CapaNegocio
{
    public class NegocioClientes
    {
        private readonly DatosClientes _datosCliente;

        public NegocioClientes()
        {
            _datosCliente = new DatosClientes();
        }

        public bool GuardarCliente(EntidadClientes entidadCliente)
        {
            if (string.IsNullOrWhiteSpace(entidadCliente.Nombre) || string.IsNullOrWhiteSpace(entidadCliente.Apellido))
            {
                throw new ArgumentException("El nombre y apellido son obligatorios.");
            }

            try
            {
                // Mapear la entidad de negocio a la entidad del modelo de datos
                Cliente cliente = new Cliente
                {
                    Nombre = entidadCliente.Nombre,
                    Apellido = entidadCliente.Apellido,
                    Email = entidadCliente.Email,
                    Telefono = entidadCliente.Telefono
                };

                return _datosCliente.AgregarCliente(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar el cliente: {ex.Message}", ex);
            }
        }

        public List<EntidadClientes> ObtenerClientes()
        {
            var clientes = _datosCliente.ObtenerClientes();

            // Convertir entidades del modelo en DTOs
            return clientes.Select(c => new EntidadClientes
            {
                ID = c.ID,
                Nombre = c.Nombre,
                Apellido = c.Apellido,
                Email = c.Email,
                Telefono = c.Telefono
            }).ToList();
        }
    }
}