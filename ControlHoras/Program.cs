using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlHoras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITrabajador trabajador = new Desarrollador("Juan","Perez","juanpr@gmail.com","11-02-2024","Nivel 1");

            ITrabajador trabajador2 = new Desarrollador("Miguel","Lara", "mgl3412c@gmail.com", "14-02-2024", "Nivel 2");

            Proyecto proyecto1 = new Proyecto("Sistema CFE", "Nivel 1", 25, "12-02-2024");
            Proyecto proyecto2 = new Proyecto("Sistema PEt", "Nivel 2", 100, "12-02-2024");

            proyecto1.asignar($"{trabajador.Nombre} {trabajador.Apellido}");
            proyecto2.asignar($"{trabajador2.Nombre} {trabajador2.Apellido}");

            Console.WriteLine($"El trabajador se llama {trabajador.Nombre} {trabajador.Apellido}, su correo es {trabajador.Email}, su ingreso fue {trabajador.FechaIngreso}");

            Console.WriteLine($"El proyecto se llama {proyecto1.Nombre} y se le asigno a {proyecto1.NombreTrabajador}");

            proyecto1.sumar(5);

            Console.WriteLine($"Duracion total en horas {proyecto1.Horas} - Horas dedicadas {proyecto1.Acumulado}");


            Console.WriteLine($"El trabajador se llama {trabajador2.Nombre} {trabajador2.Apellido}, su correo es {trabajador2.Email}, su ingreso fue {trabajador2.FechaIngreso}");

            Console.WriteLine($"El proyecto se llama {proyecto2.Nombre} y se le asigno a {proyecto2.NombreTrabajador}");

            proyecto2.sumar(100);

            proyecto2.sumar(2);

            Console.WriteLine($"Duracion total en horas {proyecto2.Horas} - Horas dedicadas {proyecto2.Acumulado}");

            Console.ReadLine();
        }
    }
}
