using System;

namespace Bryan_itics_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio del Proyecto de Git y GitHub");
            Director director = new Director("Liceo Guatemala", 6000, "Jorge Mendez", 40, 'M');
            director.DatosPersona();
            director.Tareas();
            Console.WriteLine("==================================================================");
        }
    }
}
