using System;
using System.Collections.Generic;
using System.Text;

namespace Bryan_itics_2020
{
    class Director : PersonaAcademica
    {
        string escuela;
        double sueldo;

        public Director()
        {

        }

        public Director(string escuela, double sueldo, string nombre, int edad, char genero) : base(nombre, edad, genero)
        {
            this.escuela = escuela;
            this.sueldo = sueldo;
        }

        public string Escuela { get => escuela; set => escuela = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }

        public override void DatosPersona()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Genero: {Genero}, Salario: {Sueldo}");
        }

        public override void Tareas()
        {
            Console.WriteLine($"Yo {Nombre}, soy el Dirctor de la escula: {Escuela}");
        }
    }
}
