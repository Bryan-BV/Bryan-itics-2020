using System;
using System.Collections.Generic;
using System.Text;

namespace Bryan_itics_2020
{
    class Estudiante : PersonaAcademica
    {
        string grado;
        string seccion;

        public Estudiante()
        {

        }
        public Estudiante(string grado, string seccion, string nombre, int edad, char genero) : base(nombre, edad, genero)
        {
            this.grado = grado;
            this.seccion = seccion;
        }

        public string Grado { get => grado; set => grado = value; }
        public string Seccion { get => seccion; set => seccion = value; }

        public override void Tareas()
        {
            Console.WriteLine($"Yo {Nombre}, soy un estudiante y estoy haciendo mis tareas");
        }

        public override void DatosPersona()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Genero: {Genero}, Grado: {Grado}, Seccion: {Seccion}");
        }
    }
}
