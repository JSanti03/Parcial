using System;
using System.Runtime.CompilerServices;

namespace Entidades
{
    public abstract class Estudiante
    {     
        public Estudiante()
        {
            
        }

        public Estudiante(int documento, string nombre, string apellido, string programa, int semestre)
        {
            Documento = documento;
            Nombre = nombre;
            Apellido = apellido;
            Programa = programa;
            Semestre = semestre;

        }

        public virtual void CargarDatos(string[] data)
        {
            Documento = int.Parse(data[1]);
            Nombre = data[2];
            Apellido = data[3];
            Programa = data[4];
            Semestre = int.Parse(data[5]);
        }

        public int Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Programa { get; set; }
        public int Semestre { get; set; }
    }
}