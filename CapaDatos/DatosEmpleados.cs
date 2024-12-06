using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatosEmpleados
    {
        // Método para guardar un nuevo empleado
        public bool Guardar(Empleado dat)
        {
            using (var modeldb = new LaYuleTravelsEntities2())
            {
                modeldb.Empleados.Add(dat);
                modeldb.SaveChanges();
                return true;
            }
        }

        // Método para mostrar todos los empleados
        public List<Empleado> MostrarDatos()
        {
            using (var modeldb = new LaYuleTravelsEntities2())
            {
                return modeldb.Empleados.ToList();
            }
        }

        // Método para modificar un empleado existente
        public bool Modificar(Empleado dat)
        {
            using (var modeldb = new LaYuleTravelsEntities2())
            {
                var tbl = modeldb.Empleados.Find(dat.ID);
                if (tbl != null)
                {
                    tbl.Nombre = dat.Nombre;
                    tbl.Apellido = dat.Apellido;
                    tbl.Puesto = dat.Puesto;
                    tbl.Salario = dat.Salario;
                    modeldb.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        // Método para eliminar un empleado por ID
        public bool Eliminar(int id)
        {
            using (var modeldb = new LaYuleTravelsEntities2())
            {
                var tbl = modeldb.Empleados.Find(id);
                if (tbl != null)
                {
                    modeldb.Empleados.Remove(tbl);
                    modeldb.SaveChanges();
                    return true;
                }
                return false;
            }
        }
    }
}