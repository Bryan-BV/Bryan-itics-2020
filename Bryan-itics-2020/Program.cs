﻿using System;

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
            Profesor profesor = new Profesor("Matematicas", 4000, "Julia Lopez", 29, 'F');
            profesor.DatosPersona();
            profesor.Tareas();
            Console.WriteLine("==================================================================");
            Estudiante estudiante = new Estudiante("3ro Basico", "A", "Luis Hernandez", 14, 'M');
            Console.WriteLine("Mostrando datos del estudiante");
            estudiante.DatosPersona();
            Console.WriteLine("Mostrando Comportamientos del Estudiante");
            estudiante.Tareas();
        }
    }
}
