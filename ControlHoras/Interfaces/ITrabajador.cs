using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlHoras
{
    public interface ITrabajador
    {
        string Nombre { get; set; }
        string Apellido { get; set; }
        string Email { get; set; }
        string FechaIngreso { get; set; }
        string Categoria { get; set; }

    }
}
