using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioEmpleados
    {
        private readonly DatosEmpleados metodos = new DatosEmpleados();

        // Método para guardar empleado
        public bool Guardar(EntidadEmpleados dat)
        {
            Empleado empleado = new Empleado
            {
                Nombre = dat.Nombre,
                Apellido = dat.Apellido,
                Puesto = dat.Puesto,
                Salario = dat.Salario
            };
            return metodos.Guardar(empleado);
        }

        // Método para mostrar datos
        public List<Empleado> MostrarDatos()
        {
            return metodos.MostrarDatos();
        }

        // Método para modificar empleado
        public bool Modificar(EntidadEmpleados dat)
        {
            Empleado empleado = new Empleado
            {
                ID = dat.ID,
                Nombre = dat.Nombre,
                Apellido = dat.Apellido,
                Puesto = dat.Puesto,
                Salario = dat.Salario
            };
            return metodos.Modificar(empleado);
        }

        // Método para eliminar empleado
        public bool Eliminar(int id)
        {
            return metodos.Eliminar(id);
        }
        public List<Empleado> MostrarDatosFiltrados(string filtroPuesto)
        {
            return metodos.MostrarDatos()
                          .Where(emp => emp.Puesto.Contains(filtroPuesto)) // Filtrar por puesto
                          .OrderBy(emp => emp.Nombre)                     // Ordenar por nombre
                          .ToList();
        }
    }
}