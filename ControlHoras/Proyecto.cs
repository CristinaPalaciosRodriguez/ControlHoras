using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlHoras
{
    public class Proyecto
    {
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public int Horas { get; set; }
        public string FechaInicio { get; set; }
        public string nombreTrabajador { get; set; }
        public int acumulado { get; set; }
        public Proyecto(string nombre, string categoria, int horas, string fechaInicio)
        {
            this.Nombre = nombre;
            this.Categoria = categoria;
            this.Horas = horas;
            this.FechaInicio = fechaInicio;
            this.acumulado = 0;
        }

        public void asignar(string nombreTrabajador)
        {
            this.nombreTrabajador = nombreTrabajador;
        }

        public void sumar(int horasDedicadas)
        {
            if(this.Horas >= (this.acumulado + horasDedicadas))
            {
                this.acumulado = this.acumulado + horasDedicadas;
            } else
            {
                Console.WriteLine($"Ya se consumieron todas las horas disponibles");
            }
        }
    }
}
