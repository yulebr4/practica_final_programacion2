using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Cita
    {
        public int ClienteID { get; set; }
        public string NombreCliente { get; set; }
        public string Excursion { get; set; }
        public DateTime Fecha { get; set; }
    }
}
