using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlHoras
{
    public class Trabajador
    {
        public Trabajador()
        {
        }
 
        public Trabajador(string nombre, string apellido, string email)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string FechaIngreso { get; set; }

    }
}
