using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlHoras
{
    public interface IProyecto
    {
        string Nombre { get; set; }
        string Categoria { get; set; }
        int Horas { get; set; }
        string FechaInicio { get; set; }
        string NombreTrabajador { get; set; }
        int Acumulado { get; set; }
        void asignar(string nombreTrabajador);
        void sumar(int horasDedicadas);
    }
}
