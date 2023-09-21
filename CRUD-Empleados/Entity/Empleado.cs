using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string NombreCompleto { get; set; }
        public Area Area { get; set; }

        public decimal Sueldo { get; set; }

        public DateTime FechaRegistro { get; set; }
    }
}
