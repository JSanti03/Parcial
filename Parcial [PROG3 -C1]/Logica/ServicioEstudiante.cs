using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Datos;
using Entidades;

namespace Logica
{
    public class ServicioEstudiante
    {
        private List<Estudiante> estudiantes;
        private Archivo archivo;

        private List<string> mPregrado = new List<string>
        {
            "SISTEMAS", "DERECHO", "ENFERMERIA", "LICENCIATURA", "MUSICA"
        };

        private List<string> mPostgrado = new List<string>()
        {
            "DESARROLLO SOFTWARE", "DERECHO ADMINISTRATIVO", "AUDITORIA EN SALUD"
        };

        public ServicioEstudiante()
        {
            estudiantes = new List<Estudiante>();
            archivo = new Archivo("Registro-Academico.dat");
            CargarDatos();
        }

        public List<Estudiante> Listar()
        {
            return estudiantes;
        }

        private void CargarDatos()
        {
            estudiantes = archivo.CargarContactos();
        }

        public string Promedio(string materia)
        {
            double promedio = 0;
            var total = 0;

            foreach (var estudiante in estudiantes)
            {
                if (estudiante.Programa.Equals(materia) && mPregrado.Contains(materia))
                {
                    var es = (Pregrado)estudiante;
                    var promEstudiantes = (es.PromedioCorte1 + es.PromedioCorte2 + es.PromedioCorte3) / 3;
                    promedio += promEstudiantes;
                    total += 1;
                }
                else if (estudiante.Programa.Equals(materia) && mPostgrado.Contains(materia))
                {
                    var es = (Postgrado)estudiante;
                    promedio += es.PromedioSemestre;
                    total += 1;
                }
            }

            Console.Clear();
            Console.WriteLine();
            var promedioFinal = promedio / total;
            return $"\n===========================================================" +
                   $"\n El promedio de {materia} es {promedioFinal}" +
                   $"\n===========================================================";

        }

        public string Destacado(string materia)
        {
            double promMaximo = 0;
            string destacado = "";
            foreach (var estudiante in estudiantes)
            {
                double promEstudiante;
                if (estudiante.Programa.Equals(materia) && mPregrado.Contains(materia))
                {
                    var es = (Pregrado)estudiante;
                    promEstudiante = (es.PromedioCorte1 + es.PromedioCorte2 + es.PromedioCorte3) / 3;

                    if (!(promEstudiante > promMaximo)) continue;
                    promMaximo = promEstudiante;
                    destacado = es.Nombre;
                }
                else if (estudiante.Programa.Equals(materia) && mPostgrado.Contains(materia))
                {
                    var es = (Postgrado)estudiante;
                    promEstudiante = es.PromedioSemestre;

                    if (!(promEstudiante > promMaximo)) continue;
                    promMaximo = promEstudiante;
                    destacado = es.Nombre;
                }
            }

            Console.Clear();
            Console.WriteLine();
            return $"\n======================================================================" +
                   $"\n El estudiante destacado de {materia} es {destacado}" +
                   $"\n======================================================================";
        }
    }
}