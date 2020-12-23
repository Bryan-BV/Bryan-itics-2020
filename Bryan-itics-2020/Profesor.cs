using System;
using System.Collections.Generic;
using System.Text;

namespace Bryan_itics_2020
{
    class Profesor : PersonaAcademica
    {
        string curosoimparte;
        double sueldo;

        public Profesor()
        {

        }

        public Profesor(string curosoimparte, double sueldo, string nombre, int edad, char genero) : base(nombre, edad, genero)
        {
            this.curosoimparte = curosoimparte;
            this.sueldo = sueldo;
        }

        public string Curosoimparte { get => curosoimparte; set => curosoimparte = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }

        public override void DatosPersona()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Genero: {Genero}, Curso que imparte: {Curosoimparte}, Salario: {Sueldo}");
        }

        public override void Tareas()
        {
            Console.WriteLine($"Yo {Nombre}, soy un(a) profesor(a) y imparto el curso de: {Curosoimparte}");
        }
    }

}
