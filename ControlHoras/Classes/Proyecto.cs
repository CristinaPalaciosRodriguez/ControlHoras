using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlHoras
{
    public class Proyecto : IProyecto
    {
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public int Horas { get; set; }
        public string FechaInicio { get; set; }
        public string NombreTrabajador { get; set; }
        public int Acumulado { get; set; }
        public Proyecto(string nombre, string categoria, int horas, string fechaInicio)
        {
            this.Nombre = nombre;
            this.Categoria = categoria;
            this.Horas = horas;
            this.FechaInicio = fechaInicio;
            this.Acumulado = 0;
        }

        public void asignar(string nombreTrabajador)
        {
            this.NombreTrabajador = nombreTrabajador;
        }

        public void sumar(int horasDedicadas)
        {
            if(this.Horas >= (this.Acumulado + horasDedicadas))
            {
                this.Acumulado = this.Acumulado + horasDedicadas;
            } else
            {
                Console.WriteLine($"Ya se consumieron todas las horas disponibles");
            }
        }
    }
}
