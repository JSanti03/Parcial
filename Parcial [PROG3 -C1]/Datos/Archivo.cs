using System.Collections.Generic;
using System.IO;
using Entidades;

namespace Datos
{
    public class Archivo
    {
        private string ruta;
        private Estudiante estudiante;
        public Archivo(string ruta)
        {
            this.ruta = ruta;
        }

        public List<Estudiante> CargarContactos()
        {

            StreamReader sr = new StreamReader(ruta);
            List<Estudiante> estudiantes = new List<Estudiante>();

            var dato = sr.ReadLine();
            while (dato != null)
            {
                var id = dato.Split(';')[0];
                if (id == "PRE")
                {
                    estudiante = new Pregrado();
                    estudiante.CargarDatos(dato.Split(';'));
                }
                else
                {
                    estudiante = new Postgrado();
                    estudiante.CargarDatos(dato.Split(';'));
                }
                estudiantes.Add(estudiante);
                dato = sr.ReadLine();
            }

            sr.Close();
            return estudiantes;
        }
    }
}