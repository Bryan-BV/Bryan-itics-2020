using System;
using System.Collections.Generic;
using System.Text;

namespace Bryan_itics_2020
{
    abstract class PersonaAcademica
    {
        string nombre;
        int edad;
        char genero;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public char Genero { get => genero; set => genero = value; }

        public PersonaAcademica()
        {


        }
        protected PersonaAcademica(string nombre, int edad, char genero)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.genero = genero;
        }

        public abstract void Tareas();
        public abstract void DatosPersona();

    }
}
