using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlHoras
{
    public class Desarrollador : Trabajador, ITrabajador
    {
        public string Categoria { get; set; }
        public Desarrollador(string nombre, string apellido, string email, string fechaIn, string categoria)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.FechaIngreso = fechaIn;
            this.Categoria = categoria;
        }

    }
}
